// OpencvImageProc.cpp : 定義 DLL 應用程式的匯出函式。
//

#include "stdafx.h"
#include "OpencvImageProc.h"
#include <windows.h>
#include <stdio.h>
#include <iostream>
#include <time.h>
#include <stdlib.h>
#include <direct.h>
#include <io.h>
#include <fstream>
#include <string>

using namespace std;
//OPENCV_IMG_PROC_DLL_PORT void CalculateGrayInfo(ImgPram ScrImg, VisionResult* result)
//{
//
//}

namespace CVision
{
	ImgProc::ImgProc()
	{
		temp_count = 0;
	}

	ImgProc::~ImgProc()
	{
	
	}

	void ImgProc::CalculateGrayInfo(ImgParam imgParam, VisionResult* result)
	{
		Mat img = Mat(imgParam.Height, imgParam.Width, CV_8UC1, (unsigned char*)imgParam.data);

		double min, max;
		Point max_locate, min_locate;
		minMaxLoc(img, &min, &max, &min_locate, &max_locate);

		Scalar meanTemp = mean(img);

		result->min = min;
		result->max = max;
		result->avg = meanTemp.val[0];
	}

	void ImgProc::CalculateGrayInfo_NoStruct(char* ptr, int width, int height, double* min, double* max, double* avg)
	{
		//I don't know why image will destroy as use Mat and width, height over 100.
		//So I use iplimage to calculate min, max, avg in following code.

		//Mat img = Mat(height, width, CV_8UC1, (unsigned char*)ptr); // I don't know why image will destroy as use Mat and width, height over 100.
		IplImage *img_temp = cvCreateImage(cvSize(width, height), IPL_DEPTH_8U, 1);
		img_temp->imageData = ptr;
		Mat img = cvarrToMat(img_temp); // I don't know why image will destroy as use Mat and width, height over 100.

		CvPoint max_locate, min_locate;
		cvMinMaxLoc(img_temp, min, max, &min_locate, &max_locate);

		CvScalar meanTemp = cvAvg(img_temp);

		*avg = meanTemp.val[0];

		// debug
		/*temp_count++;
		char FileName[255], msg[500];
		::sprintf_s(msg, "%d_th roi:\n min = %f, max = %f, avg = %f", temp_count, double(*min), double(*max), double(*avg));
		Log((const char*)&msg);
		::sprintf(FileName, "DebugInformation\\%d_th_img.bmp", temp_count);
		cvSaveImage(FileName, img_temp);*/
		
	}

	void ImgProc::GreateFolder(const char* Folder)
	{
		string FolderTemp(Folder);
		string FatherFolder;
		string separate = "\\";
		int starPos = 0, endPos = 0, len = FolderTemp.length();

		while (len > 0)
		{
			endPos = FolderTemp.find(separate.c_str(), endPos, 1);
			if (endPos != string::npos)
				len = len - FolderTemp.copy((char*)FatherFolder.c_str(), endPos - starPos + 1, starPos);
			else
				len = len - FolderTemp.copy((char*)FatherFolder.c_str(), FolderTemp.length(), starPos);

			if (access(FatherFolder.c_str(), 0))
				_mkdir(FatherFolder.c_str());

			endPos++;
		}
	}

	// 用FILE寫的log檔
	void ImgProc::Log(const char* Message)
	{
		char Folder[50] = "DebugInformation\\Log";
		GreateFolder(Folder);

		char file[60], filename[30];
		char OccurTime[100];
		memset(OccurTime, 0, sizeof(OccurTime));

		char BeWriteMsg[300];

		time_t t = time(0);
		strftime(filename, sizeof(Folder), "%Y%m%d", localtime(&t));
		strcat(filename, "Log.log");

		strcpy(file, Folder);
		strcat(file, "\\");
		strcat(file, filename);

		try
		{
			if (!access(Folder, 0))
			{
				FILE *logFile;
				logFile = fopen(file, "a+");
				if (logFile == NULL)
					perror("Error opening file");
				else
				{
					t = time(0);
					strftime(OccurTime, sizeof(OccurTime), "%Y/%m/%d %H:%M:%S : ", localtime(&t));

					sprintf(BeWriteMsg, "%s%s\n", OccurTime, Message);
					fputs(BeWriteMsg, logFile);

					fflush(logFile);
					fclose(logFile);
				}
			}
			else
			{
				int a = _mkdir(Folder);

				FILE *logFile;
				logFile = fopen(file, "a+");
				if (logFile == NULL)
					perror("Error opening file");
				else
				{
					t = time(0);
					strftime(OccurTime, sizeof(OccurTime), "%Y/%m/%d %H:%M:%S : ", localtime(&t));

					sprintf(BeWriteMsg, "%s%s\n", OccurTime, Message);
					fputs(BeWriteMsg, logFile);

					fflush(logFile);
					fclose(logFile);
				}
			}
		}
		catch (...)
		{
			FILE *logFile;
			strftime(filename, sizeof(Folder), "%Y%m%d", localtime(&t));
			strcat(filename, "FileOpenFail.log");
			logFile = fopen(filename, "a+");
			if (logFile == NULL)
				perror("Error opening file");
			else
			{
				t = time(0);
				strftime(OccurTime, sizeof(OccurTime), "%Y/%m/%d %H:%M:%S : ", localtime(&t));

				fputs("Having some error!", logFile);
				sprintf(BeWriteMsg, "%s Error is \n", OccurTime, ferror(logFile));
				fputs(BeWriteMsg, logFile);

				fflush(logFile);
				fclose(logFile);
			}
		}
	}
}

#pragma once
#include "stdafx.h"
#include "opencv2\opencv.hpp"

using namespace cv;

//OPENCV_IMG_PROC_DLL_PORT void CalculateGrayInfo(ImgPram ScrImg, VisionResult* result);
namespace CVision
{
	typedef struct
	{
		int min;
		int max;
		float avg;
	}VisionResult;

	typedef struct
	{
		int Width;
		int Height;
		unsigned char* data;
		int channels;
	}ImgParam;

	public ref class ImgProc
	{
	public:
		ImgProc();
		~ImgProc();
		void CalculateGrayInfo(ImgParam imgParam, VisionResult* result);
		void CalculateGrayInfo_NoStruct(char* ptr, int width, int height, double* min, double* max, double* avg);

	private:
		int temp_count;
		void Log(const char* Message);
		void GreateFolder(const char* Folder);
	};

	
	
}
// stdafx.h : �i�b�����Y�ɤ��]�t�зǪ��t�� Include �ɡA
// �άO�g�`�ϥΫo�ܤ��ܧ�
// �M�ױM�� Include �ɮ�
//

#pragma once

#include "targetver.h"

#define WIN32_LEAN_AND_MEAN             // �q Windows ���Y�ư����`�ϥΪ�����
// Windows ���Y��: 
#include <windows.h>

#ifndef OPENCV_IMG_PROC_DLL
#define OPENCV_IMG_PROC_DLL_PORT _declspec(dllexport)
#else
#define OPENCV_IMG_PROC_DLL_PORT _declspec(dllimport)
#endif // !OPENCV_IMG_PROC_DLL

// TODO:  �b���Ѧұz���{���һݭn����L���Y

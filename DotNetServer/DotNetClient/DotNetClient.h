
// DotNetClient.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������
#include "stdafx.h"

// CDotNetClientApp: 
// �йش����ʵ�֣������ DotNetClient.cpp
//

class CDotNetClientApp : public CWinApp
{
public:
	CDotNetClientApp();

// ��д
public:
	virtual BOOL InitInstance();

// ʵ��

	DECLARE_MESSAGE_MAP()
};

extern CDotNetClientApp theApp;


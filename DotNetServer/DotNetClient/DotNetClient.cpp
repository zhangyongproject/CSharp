
// DotNetClient.cpp : ����Ӧ�ó��������Ϊ��
//

#include "stdafx.h"
#include "DotNetClient.h"
#include "DotNetClientDlg.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#endif


/*****************************************����TLB*********************************************/
#ifdef _DEBUG
#import "..\..\output/DotNetServer/Debug/DotNetServer.tlb" named_guids raw_interfaces_only
#else
#import "..\..\output/DotNetServer/Release/DotNetServer.tlb" named_guids raw_interfaces_only
#endif // _DEBUG
using namespace DotNetServer;

/*****************************************�¼���Ӧ*********************************************/
#include <atlbase.h>
#include <atlcom.h>
extern CComModule _Module;

class CEventHandler : public IDispEventImpl<4, CEventHandler,
	&DIID_IMathEvents, &LIBID_DotNetServer, 1, 0>
{
public:
	BEGIN_SINK_MAP(CEventHandler)
		SINK_ENTRY_EX(4, DIID_IMathEvents, 46200, OnCalcCompleted)
	END_SINK_MAP()

	HRESULT __stdcall OnCalcCompleted()
	{
		MessageBox(NULL,_T("OnCalcCompleted"), NULL, MB_OK);
		int a = 0; 
		a = 10;
		return S_OK;
	}
};

/**************************************************************************************/

// CDotNetClientApp

BEGIN_MESSAGE_MAP(CDotNetClientApp, CWinApp)
	ON_COMMAND(ID_HELP, &CWinApp::OnHelp)
END_MESSAGE_MAP()


// CDotNetClientApp ����

CDotNetClientApp::CDotNetClientApp()
{
	// ֧����������������
	m_dwRestartManagerSupportFlags = AFX_RESTART_MANAGER_SUPPORT_RESTART;

	// TODO:  �ڴ˴���ӹ�����룬
	// ��������Ҫ�ĳ�ʼ�������� InitInstance ��
}


// Ψһ��һ�� CDotNetClientApp ����

CDotNetClientApp theApp;


// CDotNetClientApp ��ʼ��
void GetXML()
{
	AfxMessageBox(_T("tttttttttttt"));
}
BOOL CDotNetClientApp::InitInstance()
{
	// ���һ�������� Windows XP �ϵ�Ӧ�ó����嵥ָ��Ҫ
	// ʹ�� ComCtl32.dll �汾 6 ����߰汾�����ÿ��ӻ���ʽ��
	//����Ҫ InitCommonControlsEx()��  ���򣬽��޷��������ڡ�
	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);
	// ��������Ϊ��������Ҫ��Ӧ�ó�����ʹ�õ�
	// �����ؼ��ࡣ
	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinApp::InitInstance();

	try
	{
		CoInitialize(NULL);
		HRESULT hr = S_OK;
		IWelcomePtr spWelcome;
		hr = spWelcome.CreateInstance("DotNetServer.DotnetComponent");

		IUnknownPtr spUnknown = spWelcome;

		CString str("Bill");
		BSTR name = str.AllocSysString();
		BSTR bstr;
		spWelcome->Greeting(name, &bstr);

		CEventHandler* eventHandler = new CEventHandler();
		hr = eventHandler->DispEventAdvise(spUnknown);



		IMathPtr spMath = spWelcome;
		spMath->GetAndCallDelegate((long)GetXML);
		long result;
		spMath->Add(4, 5, &result);

		eventHandler->DispEventUnadvise(spWelcome.GetInterfacePtr());
		delete eventHandler;
	}
	catch (_com_error& e)
	{
		CString str;
		str = e.ErrorMessage();
		OutputDebugString(str);

		CoUninitialize();
	}
	AfxEnableControlContainer();

	// ���� shell ���������Է��Ի������
	// �κ� shell ����ͼ�ؼ��� shell �б���ͼ�ؼ���
	CShellManager *pShellManager = new CShellManager;

	// ���Windows Native���Ӿ����������Ա��� MFC �ؼ�����������
	CMFCVisualManager::SetDefaultManager(RUNTIME_CLASS(CMFCVisualManagerWindows));

	// ��׼��ʼ��
	// ���δʹ����Щ���ܲ�ϣ����С
	// ���տ�ִ���ļ��Ĵ�С����Ӧ�Ƴ�����
	// ����Ҫ���ض���ʼ������
	// �������ڴ洢���õ�ע�����
	// TODO:  Ӧ�ʵ��޸ĸ��ַ�����
	// �����޸�Ϊ��˾����֯��
	SetRegistryKey(_T("Ӧ�ó��������ɵı���Ӧ�ó���"));

	CDotNetClientDlg dlg;
	m_pMainWnd = &dlg;
	INT_PTR nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
		// TODO:  �ڴ˷��ô����ʱ��
		//  ��ȷ�������رնԻ���Ĵ���
	}
	else if (nResponse == IDCANCEL)
	{
		// TODO:  �ڴ˷��ô����ʱ��
		//  ��ȡ�������رնԻ���Ĵ���
	}
	else if (nResponse == -1)
	{
		TRACE(traceAppMsg, 0, "����: �Ի��򴴽�ʧ�ܣ�Ӧ�ó���������ֹ��\n");
		TRACE(traceAppMsg, 0, "����: ������ڶԻ�����ʹ�� MFC �ؼ������޷� #define _AFX_NO_MFC_CONTROLS_IN_DIALOGS��\n");
	}

	// ɾ�����洴���� shell ��������
	if (pShellManager != NULL)
	{
		delete pShellManager;
	}

	// ���ڶԻ����ѹرգ����Խ����� FALSE �Ա��˳�Ӧ�ó���
	//  ����������Ӧ�ó������Ϣ�á�
	return FALSE;
}


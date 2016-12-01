
// DotNetClient.cpp : 定义应用程序的类行为。
//

#include "stdafx.h"
#include "DotNetClient.h"
#include "DotNetClientDlg.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#endif


/*****************************************导入TLB*********************************************/
#ifdef _DEBUG
#import "..\..\output/DotNetServer/Debug/DotNetServer.tlb" named_guids raw_interfaces_only
#else
#import "..\..\output/DotNetServer/Release/DotNetServer.tlb" named_guids raw_interfaces_only
#endif // _DEBUG
using namespace DotNetServer;

/*****************************************事件响应*********************************************/
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


// CDotNetClientApp 构造

CDotNetClientApp::CDotNetClientApp()
{
	// 支持重新启动管理器
	m_dwRestartManagerSupportFlags = AFX_RESTART_MANAGER_SUPPORT_RESTART;

	// TODO:  在此处添加构造代码，
	// 将所有重要的初始化放置在 InitInstance 中
}


// 唯一的一个 CDotNetClientApp 对象

CDotNetClientApp theApp;


// CDotNetClientApp 初始化
void GetXML()
{
	AfxMessageBox(_T("tttttttttttt"));
}
BOOL CDotNetClientApp::InitInstance()
{
	// 如果一个运行在 Windows XP 上的应用程序清单指定要
	// 使用 ComCtl32.dll 版本 6 或更高版本来启用可视化方式，
	//则需要 InitCommonControlsEx()。  否则，将无法创建窗口。
	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);
	// 将它设置为包括所有要在应用程序中使用的
	// 公共控件类。
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

	// 创建 shell 管理器，以防对话框包含
	// 任何 shell 树视图控件或 shell 列表视图控件。
	CShellManager *pShellManager = new CShellManager;

	// 激活“Windows Native”视觉管理器，以便在 MFC 控件中启用主题
	CMFCVisualManager::SetDefaultManager(RUNTIME_CLASS(CMFCVisualManagerWindows));

	// 标准初始化
	// 如果未使用这些功能并希望减小
	// 最终可执行文件的大小，则应移除下列
	// 不需要的特定初始化例程
	// 更改用于存储设置的注册表项
	// TODO:  应适当修改该字符串，
	// 例如修改为公司或组织名
	SetRegistryKey(_T("应用程序向导生成的本地应用程序"));

	CDotNetClientDlg dlg;
	m_pMainWnd = &dlg;
	INT_PTR nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
		// TODO:  在此放置处理何时用
		//  “确定”来关闭对话框的代码
	}
	else if (nResponse == IDCANCEL)
	{
		// TODO:  在此放置处理何时用
		//  “取消”来关闭对话框的代码
	}
	else if (nResponse == -1)
	{
		TRACE(traceAppMsg, 0, "警告: 对话框创建失败，应用程序将意外终止。\n");
		TRACE(traceAppMsg, 0, "警告: 如果您在对话框上使用 MFC 控件，则无法 #define _AFX_NO_MFC_CONTROLS_IN_DIALOGS。\n");
	}

	// 删除上面创建的 shell 管理器。
	if (pShellManager != NULL)
	{
		delete pShellManager;
	}

	// 由于对话框已关闭，所以将返回 FALSE 以便退出应用程序，
	//  而不是启动应用程序的消息泵。
	return FALSE;
}


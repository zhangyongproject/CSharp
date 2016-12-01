using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
/*
 * 1.说明： 注册.NET COM组件并生成tlb 使用  
 * 2.regasm DotnetServer.dll /tlb
 * 
 * 3.连接点接口  必须是调度接口(InterfaceIsIDispatch)或自定义接口一般选调度接口
 * 4.在类上使用[ComSourceInterfaces(typeof(IMathEvents))] 说明连接点接口是输出接口
 * 5.在类中必须为源接口(即连接点接口)的每个方法声明一个事件，方法的类型必须是 委托的名称，事件的名称必须与源接口中的方法的名称完全相同
*/
namespace DotNetServer
{
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisible(true)]
    public interface IMathEvents
    {
        [DispId(46200)]
        void CalculationCompleted();
    }

    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IWelcome
    {
        [DispId(60040)]
        string Greeting(string name);
    }

    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComVisible(true)]
    public interface IMath
    {
        int Add(int val1, int val2);
        int Sub(int val1, int val2);
        void GetAndCallDelegate(long dd);
    }

    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("DotNetServer.DotnetComponent")]
    [Guid("77839717-40DD-4876-8297-35B98A8402C7")]
    [ComSourceInterfaces(typeof(IMathEvents))]
    [ComVisible(true)]
    public class DotnetComponent : IWelcome, IMath
    {
        public DotnetComponent()
        {
        }

        public event Action CalculationCompleted;

        public string Greeting(string name)
        {
            return "Hello " + name;
        }

        public int Add(int val1, int val2)
        {
            int result = val1 + val2;
            if (CalculationCompleted != null)
            {
                CalculationCompleted();
            }
            return result;

        }

        public int Sub(int val1, int val2)
        {
            int result = val1 - val2;
            if (CalculationCompleted != null)
                CalculationCompleted();
            return result;

        }

        public void GetAndCallDelegate(long dd)
        {
            
            Action xx = (Action)Marshal.GetDelegateForFunctionPointer((IntPtr)dd, typeof(Action));

            if(xx != null)
                xx();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Adapter：将一个类的接口转换成客户希望的另一个接口，使得原来由于接口不兼容而不能一起工作的那些类可以一起工作。

       适配器(变压器)模式：把一个类的接口变换成客户端所期待的另一种接口，从而使原本因接口原因不匹配而无法一起工作的两个类能够一起工作。适配类可以根据参数返还一个合适的实例给客户端。
 */
namespace DesignMode.Abstract_Factory
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }

    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}

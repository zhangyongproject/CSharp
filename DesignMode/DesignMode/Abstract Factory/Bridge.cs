using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
       Bridge：将抽象部分与它的实现部分分离，使之可以独立变化。

      桥梁模式：将抽象化与实现化脱耦，使得二者可以独立的变化，也就是说将他们之间的强关联变成弱关联，
 * 也就是指在一个软件系统的抽象化和实现化之间使用组合/聚合关系而不是继承关系，从而使两者可以独立的变化。
 */
namespace DesignMode.Abstract_Factory
{
    abstract class Implementor
    {
        public abstract void Operation();
    }

    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }

    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }

    class Abstraction
    {
        private Implementor implementor;

        public Implementor _implementor
        {
            get { return implementor; }
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            _implementor.Operation();
        }
    }

    class BridgeClient
    {
        public void main()
        {
            Abstraction ab = new RefinedAbstraction();
            ab._implementor = new ConcreteImplementorA();
            ab.Operation();

            ab._implementor = new ConcreteImplementorB();
            ab.Operation();

            Console.Read();
        }
    }

}

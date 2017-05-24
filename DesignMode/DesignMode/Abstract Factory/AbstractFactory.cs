using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*   Abstract Factory：提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。

    工厂模式：客户类和工厂类分开。消费者任何时候需要某种产品，只需向工厂请求即可。

消费者无须修改就可以接纳新产品。缺点是当产品修改时，工厂类也要做相应的修改。如：如何创建及如何向客户端提供。
 */
namespace DesignMode.Abstract_Factory
{
    abstract class AbstractProductA
    {

    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class ProductA1: AbstractProductA
    {

    }

    class ProductB1: AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            ;
        }
    }

    class ProductA2 : AbstractProductA
    {

    }

    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            ;
        }
    }


    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    class ConcreteFactory1: AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    class Client
    {
        private AbstractProductA abstractproducta;
        private AbstractProductB abstractproductb;

        public Client(AbstractFactory factory)
        {
            abstractproducta = factory.CreateProductA();
            abstractproductb = factory.CreateProductB();
        }

        public void Run()
        {
            abstractproductb.Interact(abstractproducta);
        }

        public void Main()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input
            Console.Read();
        }
    }
}

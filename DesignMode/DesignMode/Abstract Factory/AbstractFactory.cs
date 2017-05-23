using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class ConcreateFactory1: AbstractFactory
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

    class ConcreateFactory2 : AbstractFactory
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
    }
}

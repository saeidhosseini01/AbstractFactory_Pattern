using AbstractFactory_Pattern.Services.ProductA;
using AbstractFactory_Pattern.Services.ProductB;

namespace AbstractFactory_Pattern.AbstractFactory
{
    public class ConcreteFactory1 : IAbsrtactFactory
    {

        public IAbstractFactoryA CreateProductA()
        {
                return new ProductA1();
        }

        public IAbstractFactoryB CreateProductB()
        {
            return new ProductB1();
        }
    }
}

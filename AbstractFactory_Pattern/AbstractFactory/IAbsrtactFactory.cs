using AbstractFactory_Pattern.Services.ProductA;
using AbstractFactory_Pattern.Services.ProductB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pattern.AbstractFactory
{
    public interface IAbsrtactFactory
    {
        IAbstractFactoryA CreateProductA();
        IAbstractFactoryB CreateProductB();
    }
}

using AbstractFactory.ProductA;
using AbstractFactory.ProductB;

namespace AbstractFactory.Factories
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
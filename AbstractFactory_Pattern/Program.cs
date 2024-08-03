// See https://aka.ms/new-console-template for more information
using AbstractFactory_Pattern.AbstractFactory;

Console.WriteLine("Hello, World!");








IAbsrtactFactory abstractFacrory1 = new ConcreteFactory2();
var product1= abstractFacrory1.CreateProductA(); 
var product2= abstractFacrory1.CreateProductB();
product1.Execute();
product2.Execute();
Console.ReadLine();
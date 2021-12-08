using System;

namespace FPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexClassA classA = new ComplexClassA();
            ComplexClassB classB = new ComplexClassB();

            Facade facade = new Facade(classA, classB);

            Client.ClientCode(facade);

            Console.WriteLine("Hello World!");
        }
    }
}

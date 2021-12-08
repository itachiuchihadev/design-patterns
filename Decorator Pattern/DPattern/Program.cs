using System;

namespace DPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new Client();
            var simple = new ConcreateComponent();
            var concreateDecoratorA = new ConcreateDecoratorA(simple);
            var concreateDecorator = new ConcreateDecorator(concreateDecoratorA);
            client.ClientCode(concreateDecorator);
        }
    }
}

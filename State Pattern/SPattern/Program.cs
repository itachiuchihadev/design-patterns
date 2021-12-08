using System;

namespace SPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var context = new Context(new FirstState());
            context.Request1();
            context.Request2();
        }
    }
}

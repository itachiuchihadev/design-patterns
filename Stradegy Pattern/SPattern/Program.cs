using System;
using SPattern.ConcreateClasses;

namespace SPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cityDuck = new Ducks(new SimpleFly(), new LoudQuack());
            cityDuck.Fly();
            cityDuck.Quack();
            Console.ReadKey();
        }
    }
}

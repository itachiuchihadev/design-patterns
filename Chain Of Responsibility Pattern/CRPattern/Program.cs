using System;
using System.Collections.Generic;

namespace CRPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var monkey = new MonkeyHandler();
            var cat = new CatHandler();
            var dog = new DogHandler();

            monkey.SetNext(cat).SetNext(dog);

            Client.ClientCode(monkey);
            Console.WriteLine();

            Client.ClientCode(cat);
            Console.WriteLine();

        }
    }
}

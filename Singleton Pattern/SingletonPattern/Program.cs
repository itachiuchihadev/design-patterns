using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingletonClass s = SingletonClass.GetSingletonInstance();
            Console.WriteLine($"First Instance Value : { s.i }");
            s.i = 1;
            SingletonClass s1 = SingletonClass.GetSingletonInstance();
            Console.WriteLine($"First Instance Value : { s1.i }");
            Console.ReadKey();            
        }
    }
}

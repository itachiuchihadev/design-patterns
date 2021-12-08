using System;

namespace APattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adpt = new Adaptee();
            ITarget target = new Adaptor(adpt);

            Console.WriteLine("Hello World!");
            Console.WriteLine(target.GetRequest());
        }
    }
}

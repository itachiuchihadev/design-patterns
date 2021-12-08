using System;

namespace TPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var data1 = new Data1();
            var data2 = new Data2();

            data1.TemplateMethod();
            Console.WriteLine();
            data2.TemplateMethod();
        }
    }
}

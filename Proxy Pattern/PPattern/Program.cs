using System;

namespace PPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxyParser = new ProxyParser("This Has to Parse");
            Console.WriteLine($"the number of characters are : {proxyParser.GetNumberOfCharacter()}");
            Console.WriteLine($"UpperCase characters are : {proxyParser.GetUpperCasesCharacter()}");
            Console.WriteLine("Hello World!");
        }
    }
}

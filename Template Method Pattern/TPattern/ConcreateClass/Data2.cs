using System;

namespace TPattern
{
    public class Data2 : AbstractClass
    {
        public override void RequiredOperation()
        {
            Console.WriteLine("Data2 : Required Operation 1");
        }

        public override void RequiredOperation2()
        {
            Console.WriteLine("Data 2 : Require Operation 2");
        }
    }
}
using System;

namespace TPattern
{
    public class Data1 : AbstractClass
    {
        public override void RequiredOperation()
        {
            Console.WriteLine("Data1 : Require Operation 1");
        }

        public override void RequiredOperation2()
        {
            Console.WriteLine("Data2 : Require Operation 2");
        }

        public override void Hook1(){
            Console.WriteLine("Data 1 : Hook 1");
        }
    }
}
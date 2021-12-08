using System;

namespace SPattern
{
    public class FourthState : State
    {
        public override void Handle1()
        {
            Console.WriteLine("Handled By Fourth State");
        }

        public override void Handle2()
        {
           Console.WriteLine("Handlerd by Fourth State");
        }
    }
}
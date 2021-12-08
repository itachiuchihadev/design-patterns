using SPattern.Interfaces;
using System;

namespace SPattern.ConcreateClasses
{
    public class FastFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This is Fast Fly Method.");
        }
    }
}
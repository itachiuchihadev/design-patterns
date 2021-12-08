using SPattern.Interfaces;
using System;

namespace SPattern.ConcreateClasses
{
    public class SimpleFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This is the Simple Fly Method.");
        }
    }
}
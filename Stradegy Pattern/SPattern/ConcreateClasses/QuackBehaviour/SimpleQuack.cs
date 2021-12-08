using System;
using SPattern.Interfaces;

namespace SPattern.ConcreateClasses
{
    public class SimpleQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("This is the Simple Quacking.");
        }
    }
}
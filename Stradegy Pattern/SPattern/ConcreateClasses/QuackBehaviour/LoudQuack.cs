using System;
using SPattern.Interfaces;

namespace SPattern.ConcreateClasses
{
    public class LoudQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("This is Loud Quacking.");
        }
    }
}
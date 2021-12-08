using System;
using OPattern.Interfaces;

namespace OPattern.ConcreateClasses
{
    public class SecondObserver : IObserver
    {
        public ISubject subject;
        public SecondObserver(ISubject subject)
        {
            this.subject = subject;
        }
        public void Update()
        {
            Console.WriteLine("Second Observer is Called.");
            Console.WriteLine($"Current State is : { subject.State }");
        }
    }
}
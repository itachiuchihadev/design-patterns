using OPattern.Interfaces;
using System;

namespace OPattern.ConcreateClasses
{
    public class FirstObserver : IObserver
    {
        public ISubject subject;
        public FirstObserver(ISubject subject)
        {
            this.subject = subject;
        }
        public void Update()
        {
            Console.WriteLine("First Observer is Called.");
            Console.WriteLine($"Currenct State : { subject.State }");
        }
    }
}
using System;
using OPattern.Interfaces;
using OPattern.ConcreateClasses;

namespace OPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ISubject subject = new Subject();
            IObserver observer1 = new FirstObserver(subject); 
            IObserver observer2 = new SecondObserver(subject);
            subject.AddObserver(observer1);
            subject.AddObserver(observer2);
            subject.HaveSomeTechLogic();
            subject.RemoveObserver(observer1);
            subject.HaveSomeTechLogic();
        }
    }
}

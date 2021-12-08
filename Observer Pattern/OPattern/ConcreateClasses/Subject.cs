using OPattern.Interfaces;
using System.Collections.Generic;
using System;

namespace OPattern.ConcreateClasses
{
    public class Subject : ISubject
    {
        public int State{get;set;} = 1;
        IList<IObserver> observerList = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void ChangeState()
        {
            foreach(var observer in observerList){
                observer.Update();
            }
        }

        public void HaveSomeTechLogic()
        {
            State = new Random().Next();
            Console.WriteLine("Some Logic is Implemented.");
            this.ChangeState();
        }
        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }
    }
}
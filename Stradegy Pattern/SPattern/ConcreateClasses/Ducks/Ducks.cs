using System;
using SPattern.Interfaces;

namespace SPattern.ConcreateClasses
{
    public class Ducks 
    {
        IFlyBehaviour flyBehaviour;
        IQuack quackBehaviour;
        public Ducks(IFlyBehaviour flyBehaviour, IQuack quackBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
            this.quackBehaviour = quackBehaviour;
        }
        public void Fly()
        {
            flyBehaviour.Fly();
        }

        public void Quack()
        {
            quackBehaviour.Quack();
        }
    }
}
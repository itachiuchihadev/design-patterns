using System;

namespace CPattern
{
    public abstract class Component
    {
        public abstract string Operation();
        public virtual void Add(Component component){
            throw new NotImplementedException("Didn't have any Implementation.");
        }
        public virtual void Remove(Component component){
            throw new NotImplementedException("Didn't have any Implementation.");
        }
        public virtual bool IsComposite(){
            return true;
        }
    }
}
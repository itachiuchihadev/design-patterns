using System;

namespace TPattern
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperation();
            this.BaseOperation3();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation2();
            this.Hook2();
        }

        public void BaseOperation1(){
            Console.WriteLine("This is Base Operation 1");
        }
        public void BaseOperation2(){
            Console.WriteLine("This is Base Operation 1");
        }
        public void BaseOperation3(){
            Console.WriteLine("This is Base Operation 3");
        }

        public abstract void RequiredOperation();
        public abstract void RequiredOperation2();
        public virtual void Hook1(){
            Console.WriteLine("Base Hook");
        }
        public virtual void Hook2(){
            Console.WriteLine("Base Hook 2");
        }
    }
}
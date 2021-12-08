using System;

namespace FPattern
{
    public class Facade
    {
        public ComplexClassA _complexClassA;
        public ComplexClassB _complexClassB;
        public Facade(ComplexClassA complexClassA, ComplexClassB complexClassB)
        {
            _complexClassA = complexClassA;
            _complexClassB = complexClassB;
        }

        public void PerformSomeOperation()
        {
            Console.WriteLine("This is Facade Class Calling the Complex Calsses.");
            this._complexClassA.Operation1();
            this._complexClassA.Operation2();
            this._complexClassB.Operation2();
            this._complexClassB.OperationA();
        }
    }
}
using System;

namespace NObjectPattern
{
    public class NullPlan : Plan
    {
        public void ExecutePlan()
        {
            Console.WriteLine("Null Plan is Executed.");
        }
    }
}
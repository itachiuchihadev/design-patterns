using System;

namespace NObjectPattern
{
    public class DefaultCustomerPlan : Plan
    {
        public void ExecutePlan()
        {
            Console.WriteLine("Default Customer Plan is Executed.");
        }
    }
}
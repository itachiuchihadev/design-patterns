using System;

namespace NObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            Customer customer;
            if(string.IsNullOrWhiteSpace(value.ToString())){
                customer = new NullCustomer();
            }
            else
            {
                customer = new PopularCustomer();
            }

            var plan = customer.GetPlan();
            plan.ExecutePlan();

        }
    }
}

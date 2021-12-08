namespace NObjectPattern
{
    public class PopularCustomer : Customer
    {
        public override Plan GetPlan() 
        {
            return new NormalCutomerPlans();
        }
    }
}
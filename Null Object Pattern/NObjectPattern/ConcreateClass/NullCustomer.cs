namespace NObjectPattern
{
    public class NullCustomer : Customer
    {
        public override bool IsNullCustomer { get{ return true; } }
        public override Plan GetPlan()
        {
            return new NullPlan();
        }
    }
}
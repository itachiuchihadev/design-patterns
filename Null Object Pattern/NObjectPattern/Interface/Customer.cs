namespace NObjectPattern
{
    public abstract class Customer
    {
        public virtual bool IsNullCustomer { get; set; }
        public virtual Plan GetPlan()
        {
            return new DefaultCustomerPlan();
        }
    }
}
namespace DPattern
{
    public class ConcreateDecorator : Decorator
    {
        public ConcreateDecorator(Component component) : base(component)
        {
        }
        public override string Operation()
        {
            return $"Concreate Decorator B { base.Operation()}";
        }
    }
}
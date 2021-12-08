namespace DPattern
{
    public class ConcreateDecoratorA : Decorator
    {
        public ConcreateDecoratorA(Component component) : base(component)
        {
        }

        public override string Operation()
        {
            return $"Concreate Decorator A { base.Operation()}";
        }
    }
}
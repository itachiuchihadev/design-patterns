namespace DPattern
{
    public abstract class Decorator : Component
    {
        public Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }

        public override string Operation()
        {
            if(this._component != null)
            {
                return this._component.Operation();
            }
            else{
                return string.Empty;
            }
        }
    }
}
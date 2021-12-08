namespace APattern
{
    public class Adaptor : ITarget
    {
        private Adaptee _adaptee;
        public Adaptor(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return this._adaptee.GetAdapteeRequest();
        }
    }
}
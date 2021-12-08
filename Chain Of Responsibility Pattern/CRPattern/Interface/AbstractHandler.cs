namespace CRPattern
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _handler;
        public virtual string Handle(string request)
        {
            if(this._handler != null)
            {
                return this._handler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._handler = handler;
            return handler;
        }
    }
}
namespace SPattern
{
    public class Context
    {
        public State _state = null;

        public Context(State state)
        {
            this.TransistionTo(state);
        }
        public void TransistionTo(State state)
        {
            this._state = state;
            this._state.SetContext(this);
        }
        public void Request1()
        {
            this._state.Handle1();
        }
        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
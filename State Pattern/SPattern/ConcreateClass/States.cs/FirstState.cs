namespace SPattern
{
    public class FirstState : State
    {
        public override void Handle1()
        {
            this._context.TransistionTo(new FourthState());
        }

        public override void Handle2()
        {
            this._context.TransistionTo(new SecondState());
        }
    }
}
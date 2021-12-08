namespace SPattern
{
    public abstract class State
    {
        public Context _context;
        public void SetContext(Context context)
        {
            _context = context;
        }

        public abstract void Handle1();
        public abstract void Handle2();
    }
}
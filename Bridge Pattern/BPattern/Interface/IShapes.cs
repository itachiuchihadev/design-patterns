namespace BPattern
{
    public class IShapes
    {
        protected IColor _color;
        public IShapes(IColor color)
        {
            _color = color;
        }

        public virtual string PaintShape()
        {
            return _color.Paint();
        }
    }
}
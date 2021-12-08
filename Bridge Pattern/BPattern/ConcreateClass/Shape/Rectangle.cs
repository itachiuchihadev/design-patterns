namespace BPattern
{
    public class Rectangle : IShapes
    {
        public Rectangle(IColor color) : base(color)
        {
        }
        public override string PaintShape()
        {
            return string.Concat("Rectangle Shape With ", base.PaintShape());
        }
    }
}
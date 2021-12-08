namespace BPattern
{
    public class Circle : IShapes
    {
        public Circle(IColor color) : base(color)
        { }
        public override string PaintShape()
        {
            return string.Concat("Circle Shape With ", base.PaintShape());
        }
    }
}
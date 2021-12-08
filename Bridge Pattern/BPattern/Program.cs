using System;

namespace BPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShapes recshape = new Rectangle(new RedColor());
            Console.WriteLine(recshape.PaintShape());
            var circleshape = new Circle(new Blue());
            Console.WriteLine(circleshape.PaintShape());
            Console.WriteLine("Hello World!");
        }
    }
}

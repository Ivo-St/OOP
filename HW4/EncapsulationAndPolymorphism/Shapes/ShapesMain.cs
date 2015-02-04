namespace Shapes
{
    using System;
    using System.Collections.Generic;
    class ShapesMain
    {
        public static void Main()
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(3),
                new Triangle(3,3,5),
                new Rectangle(5,10)
            };

            foreach(var shape in shapes)
            {
                Console.WriteLine("Shape Type: {0}\n Area: {1:N2}\n Perimeter: {2:N2}", shape.GetType().Name,
                    shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}

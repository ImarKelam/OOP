namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class MainClass
    {
        public static void Main()
        {
            IList<IShape> figures = new List<IShape>
            {
                new Triangle(11, 18.5, 16.2),
                new Rectangle(2, 4),
                new Circle(8)
            };

            foreach (var fig in figures)
            {
                Console.WriteLine(fig.GetType() + "  Area: " + fig.CalculateArea() + "  Perimeter: " + fig.CalculatePerimeter());
            }
        }
    }
}

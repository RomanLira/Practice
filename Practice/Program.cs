using System;
using Figure;

namespace Practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Line line = new Line(new Point(0, 0), new Point(3, 4));
            Console.WriteLine("Line\nPoint1: ({0:0.##},{1:0.##})\nPoint2: ({2:0.##},{3:0.##})",
                line._point1._x, line._point1._y, line._point2._x, line._point2._y);
            Console.WriteLine("Length: {0:0.##}\n", line.Length());
            Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 4));
            Console.WriteLine("Triangle\nPoint1: ({0:0.##},{1:0.##})\nPoint2: ({2:0.##},{3:0.##})\n" +
                              "Point3: ({4:0.##},{5:0.##})",
                triangle._point1._x, triangle._point1._y, triangle._point2._x, triangle._point2._y,
                triangle._point3._x, triangle._point3._y);
            Console.WriteLine("Area: {0:0.##}", triangle.Area());
            Console.WriteLine("Perimeter: {0:0.##}\n", triangle.Perimeter());
            Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(3, 0),
                new Point(3, 4), new Point(0, 4));
            Console.WriteLine("Rectangle\nPoint1: ({0:0.##},{1:0.##})\nPoint2: ({2:0.##},{3:0.##})\n" +
                              "Point3: ({4:0.##},{5:0.##})\nPoint4: ({6:0.##},{7:0.##})",
                rectangle._point1._x, rectangle._point1._y, rectangle._point2._x, rectangle._point2._y,
                rectangle._point3._x, rectangle._point3._y, rectangle._point4._x, rectangle._point4._y);
            Console.WriteLine("Area: {0:0.##}", rectangle.Area());
            Console.WriteLine("Perimeter: {0:0.##}\n", rectangle.Perimeter());
        }
    }
}
using System;
namespace Figure
{
    public class Rectangle : Triangle
    {
        readonly public  Point _point4;

        public Rectangle(Point point1, Point point2, Point point3, Point point4) : base(point1, point2, point3)
        {
            _point4 = point4;
        }

        public override double Area()
        {
            double a = Length(_point1, _point2);
            double b = Length(_point2, _point3);
            double c = Length(_point3, _point4);
            double d = Length(_point4, _point1);
            double p = (a + b + c + d) / 2.0;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
        }

        public override double Perimeter()
        {
            double a = Length(_point1, _point2);
            double b = Length(_point2, _point3);
            double c = Length(_point3, _point4);
            double d = Length(_point4, _point1);
            return a+b+c+d;
        }
    }
}
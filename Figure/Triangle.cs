using System;
namespace Figure
{
    public class Triangle : Line
    {
        readonly public  Point _point3;
        public Triangle(Point point1, Point point2,Point point3):base(point1,point2)
        {
            _point3 = point3;
        }

        public virtual double Area()
        {
            return 1 / 2.0 * Math.Abs((_point2._x - _point1._x) * (_point3._y - _point1._y) -
                                      (_point3._x - _point1._x) * (_point2._y - _point1._y));
        }

        public virtual double Perimeter()
        {
            
            double a = Length(_point1, _point2);
            double b = Length(_point2, _point3);
            double c = Length(_point1, _point3);
            return a + b + c;
        }
    }
}
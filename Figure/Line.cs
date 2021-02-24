namespace Figure
{
    public class Line
    {
        readonly public Point _point1;
        readonly public Point _point2;

        public Line(Point start,Point end)
        {
            _point1 = start;
            _point2 = end;
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow((_point2._x - _point1._x), 2) + Math.Pow((_point2._y - _point1._y), 2));
        }
        protected double Length(Point point1,Point point2)
        {
            return Math.Sqrt(Math.Pow((point2._x - point1._x), 2) + Math.Pow((point2._y - point1._y), 2));
        }
    }
}
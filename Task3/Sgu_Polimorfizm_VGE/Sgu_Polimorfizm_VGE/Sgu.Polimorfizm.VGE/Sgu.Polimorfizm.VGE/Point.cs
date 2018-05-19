using System;


namespace Sgu.Polimorfizm.VGE
{
    public struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public static Point operator -(Point a, Point b)
        {
            return new Point { X = b.X - a.X, Y = b.Y - a.Y };
        }

        public static double GetLength(Point a, Point b)
        {
            Point vector = b - a;
            return Math.Sqrt(Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2));
        }
    }
}

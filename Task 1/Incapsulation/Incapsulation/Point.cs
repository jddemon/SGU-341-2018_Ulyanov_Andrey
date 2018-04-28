using System;

namespace Incapsulation
{
    public class Point
    {
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public double GetDistance(Point pt1)
        {
            if (pt1 == null)
            {
                throw new ArgumentNullException(nameof(pt1), "point can't be null");
            }

            return Math.Sqrt(
                Math.Pow(pt1.X - this.X, 2) +
                Math.Pow(pt1.Y - this.Y, 2) +
                Math.Pow(pt1.Z - this.Z, 2)
            );
        }
    }
}

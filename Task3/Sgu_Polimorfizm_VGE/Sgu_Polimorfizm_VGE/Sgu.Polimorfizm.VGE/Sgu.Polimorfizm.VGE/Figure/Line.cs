using System;
using Sgu.Polimorfizm.VGE.Interface;

namespace Sgu.Polimorfizm.VGE.Figure
{
    public class Line : Figure, IDraw
    {
        public Line(Point point1, Point point2)
        {
            this.Point1 = point1;
            this.Point2 = point2;
        }


        public Point Point1 { get; set; }

        public Point Point2 { get; set; }

        public double LineLength
        {
            get
            {
                return Point.GetLength(Point1, Point2);
            }
        }

        //public void Draw()
        //{
        //    Console.WriteLine("Draw Line");
        //}

        public string Info()
        {
            return $"Начало: {Point1.X}:{Point1.Y}{Environment.NewLine}" +
                $"Конец: {Point2.X}:{Point2.Y}{Environment.NewLine}" +
                $"Длина: {LineLength}{Environment.NewLine}";
        }

        public override void DrawFigure()
        {
            base.DrawFigure();
        }
    }
}

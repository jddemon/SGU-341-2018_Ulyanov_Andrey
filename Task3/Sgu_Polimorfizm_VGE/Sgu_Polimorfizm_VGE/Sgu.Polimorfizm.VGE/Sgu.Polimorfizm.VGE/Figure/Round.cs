using System;
using Sgu.Polimorfizm.VGE.Interface;

namespace Sgu.Polimorfizm.VGE.Figure
{
    public class Round : Figure, IDraw
    {
        private double radius;

        public Round(Point point, double radius)
        {
            this.Center = point;
            this.Radius = radius;
        }

        public Point Center { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius is less then zero");
                }
            }
        }

        public double GetArea
        {
            get
            {
                return Radius * Radius * Math.PI;
            }
        }

        //public void Draw()
        //{
        //    Console.WriteLine("Draw Round");
        //}

        public string Info()
        {
            return $"Радиус = {Radius}{Environment.NewLine}" +
                $"Центр: {Center.X}:{Center.Y}{Environment.NewLine}" +
                $"Площадь: {GetArea}{Environment.NewLine}";
        }

        public override void DrawFigure()
        {
            base.DrawFigure();
        }


    }
}

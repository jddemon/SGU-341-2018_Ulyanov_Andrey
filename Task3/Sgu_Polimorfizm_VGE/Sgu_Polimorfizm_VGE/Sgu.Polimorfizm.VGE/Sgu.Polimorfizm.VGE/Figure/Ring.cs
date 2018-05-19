using System;
using Sgu.Polimorfizm.VGE.Interface;

namespace Sgu.Polimorfizm.VGE.Figure
{
    public class Ring : Figure, IDraw
    {
        private double radius;

        public Ring(Circle circle1, double radius)
        {
            this.Circle1 = circle1;
            this.radius = radius;
        }

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
                else throw new ArgumentException("Radius is less then zero");
            }
        }

        public Circle Circle1 { get; set; }

        //public void Draw()
        //{
        //    Console.WriteLine("Draw Ring");
        //}

        public string Info()
        {
            return $"Центр: {Circle1.Center.X}:{Circle1.Center.Y}{Environment.NewLine}" +
                $"Первый радиус: {Circle1.Radius}{Environment.NewLine}" +
                $"Второй радиус: {Radius}{Environment.NewLine}";
        }

        public override void DrawFigure()
        {
            base.DrawFigure();
        }

    }
}

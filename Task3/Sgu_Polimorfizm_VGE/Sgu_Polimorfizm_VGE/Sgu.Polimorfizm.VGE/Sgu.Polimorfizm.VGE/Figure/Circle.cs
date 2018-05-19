using Sgu.Polimorfizm.VGE.Interface;
using System;


namespace Sgu.Polimorfizm.VGE.Figure
{
  public class Circle : Figure, IDraw
    {
            private double radius;

            public Circle(Point point, double radius)
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

            public double GetLengthCircle
            {
                get
                {
                    return Radius * 2 * Math.PI;
                }
            }

            //public void Draw()
            //{
            //    Console.WriteLine("Draw Circle");
            //}

            public string Info()
            {
                return $"Радиус = {Radius}{Environment.NewLine}" +
                    $"Центр: {Center.X}:{Center.Y}{Environment.NewLine}" +
                    $"Длина окружности: {GetLengthCircle}{Environment.NewLine}";
            }

            public override void DrawFigure()
            {
                base.DrawFigure();
            }
    }
}


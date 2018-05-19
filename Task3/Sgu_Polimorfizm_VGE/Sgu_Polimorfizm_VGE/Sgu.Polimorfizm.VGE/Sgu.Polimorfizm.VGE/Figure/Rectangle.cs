using System;
using Sgu.Polimorfizm.VGE.Interface;

namespace Sgu.Polimorfizm.VGE.Figure
{
    public class Rectangle : Figure, IDraw
    {
        private double line1;
        private double line2;

        public Rectangle(double line1, double line2)
        {
            this.line1 = line1;
            this.line2 = line2;
        }


        private double Line1
        {
            get
            {
                return line1;
            }
            set
            {
                if (value > 0)
                {
                    line1 = value;
                }
                else
                {
                    throw new Exception("Invalid value");
                }
            }
        }

        private double Line2
        {
            get
            {
                return line2;
            }
            set
            {
                if (value > 0)
                {
                    line2 = value;
                }
                else
                {
                    throw new Exception("Invalid value");
                }
            }
        }

        //public void Draw()
        //{
        //    Console.WriteLine("Draw Rectangle");
        //}

        public string Info()
        {
            return $"Сторона A: {Line1}{Environment.NewLine}" +
                $"Сторона B: {Line2}{Environment.NewLine}";
        }

        public override void DrawFigure()
        {
            Console.WriteLine("Draw Rectangle");
        }

    }
}

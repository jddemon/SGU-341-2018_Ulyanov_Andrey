using System;
using Sgu.Polimorfizm.VGE.Interface;
using Sgu.Polimorfizm.VGE.Figure;

namespace Sgu.Polimorfizm.VGE
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDraw line = new Line(new Point { X = 3, Y = 3 }, new Point { X = 5, Y = 5 });
            //line.Draw();
            Line line = new Line(new Point { X = 3, Y = 3 }, new Point { X = 5, Y = 5 });
            line.DrawFigure();
            Console.WriteLine(line.Info());
            
            //IDraw circle = new Circle( new Point { X = 3, Y = 3}, 4);
            //circle.Draw();
            Circle circle = new Circle(new Point { X = 3, Y = 3 }, 4);
            circle.DrawFigure();
            Console.WriteLine(circle.Info());

            //IDraw round = new Round(new Point { X = 3, Y = 3 }, 4);
            //round.Draw();
            Round round =  new Round(new Point { X = 3, Y = 3 }, 4);
            round.DrawFigure();
            Console.WriteLine(round.Info());

            //IDraw ring = new Ring((Circle)circle, 12);
            //ring.Draw();
            Ring ring = new Ring((Circle)circle, 12);
            ring.DrawFigure();
            Console.WriteLine(ring.Info());

            Rectangle rectn = new Rectangle(3, 4);
            // rectn.Draw();
            rectn.DrawFigure();
            Console.WriteLine(rectn.Info());
        }
    }
}

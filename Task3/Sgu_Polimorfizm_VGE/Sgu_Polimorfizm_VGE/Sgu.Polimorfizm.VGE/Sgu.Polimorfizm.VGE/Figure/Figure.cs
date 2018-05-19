using System;

namespace Sgu.Polimorfizm.VGE.Figure
{
    public abstract class Figure
    {
        public virtual void DrawFigure()
        {
            Console.WriteLine("Draw Figure");
        }
    }
}

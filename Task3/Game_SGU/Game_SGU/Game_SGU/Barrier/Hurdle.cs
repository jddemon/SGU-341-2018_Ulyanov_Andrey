using System;
using Game_SGU.Logic_GM;

namespace Game_SGU.Barrier
{
    public class Hurdle : FixedObject
    {
            public Hurdle(Point position, int strength) : base(position)
            {
                this.Strength = strength;
            }

            public int Strength { get; set; }
    }
}

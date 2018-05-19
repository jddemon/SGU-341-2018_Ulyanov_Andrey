using System;
using Game_SGU.Logic_GM;

namespace Game_SGU.Hunter
{
    public class Hunt : Unit
    {
            public Hunt(int health, Point position, int powerOfHit) : base(health, position)
            {
                this.PowerOfHit = powerOfHit;
            }

            public override Point Move(Point move)
            {
                return Position = new Point { X = Position.X + move.X, Y = Position.Y + move.Y };
            }

            public int PowerOfHit { get; set; }
      }
 }

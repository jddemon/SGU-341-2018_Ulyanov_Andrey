using System;
using Game_SGU.Logic_GM;

namespace Game_SGU.Hero
{
    public class Player : Unit
    {
        public Player(int health, Point position) : base(health, position)
        {
            this.Power = 0;
        }

        public int Power { get; set; }

        public override Point Move(Point move)
        {
            return Position = new Point { X = Position.X + move.X, Y = Position.Y + move.Y };
        }
    }
}

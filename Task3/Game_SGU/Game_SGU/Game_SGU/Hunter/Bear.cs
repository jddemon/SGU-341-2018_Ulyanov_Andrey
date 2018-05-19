using System;
using Game_SGU.Logic_GM;

namespace Game_SGU.Hunter
{
    public class Bear : Hunt
    {
        public Bear(int health, Point position, int powerOfHit)
            : base(health, position, powerOfHit)
        {
        }
    }
}

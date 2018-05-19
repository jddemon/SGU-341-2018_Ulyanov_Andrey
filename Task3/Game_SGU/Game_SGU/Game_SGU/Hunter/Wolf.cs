using System;
using Game_SGU.Logic_GM;

namespace Game_SGU.Hunter
{
    public class Wolf: Hunt
    {
        public Wolf (int health, Point position, int powerOfHit) 
            : base(health, position, powerOfHit)
        {
        }
    }
}

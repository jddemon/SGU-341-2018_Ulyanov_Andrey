using System;

namespace Game_SGU.Field
{
    public class Small: Area
    {
        public Small(int width, int height, int amountsOfHunter, int amountOfBarrier, int amountOfBonuses)
            : base(width, height, amountsOfHunter, amountOfBarrier, amountOfBonuses)
        {
        }
    }
}

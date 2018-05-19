using System;

namespace Game_SGU.Field
{
    public abstract class Area
    {
        public Area(int width, int height, int amountsOfHunter, int amountOfBarrier, int amountOfBonuses)
        {
            this.Width = width;
            this.Height = height;
            this.AmountOfHunter = amountsOfHunter;
            this.AmountOfBarrier = amountOfBarrier;
            this.AmountOfBonuses = amountOfBonuses;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public int AmountOfHunter { get; set; }
        public int AmountOfBarrier { get; set; }
        public int AmountOfBonuses { get; set; }
    }
}

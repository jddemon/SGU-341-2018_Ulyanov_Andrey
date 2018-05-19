using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_SGU.Field
{
    public class Big: Area
    {
        public Big(int width, int height, int amountsOfHunter, int amountOfBarrier, int amountOfBonuses)
            : base(width, height, amountsOfHunter, amountOfBarrier, amountOfBonuses)
        {
        }
    }
}

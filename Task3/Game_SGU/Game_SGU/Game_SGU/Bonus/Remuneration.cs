using System;
using Game_SGU.Logic_GM;

namespace Game_SGU.Bonus
{
   public class Remuneration : FixedObject
      {
            public Remuneration(Point position, int power) : base(position)
            {
                this.Power = power;
            }

            protected int Power { get; set; }

            public string Time(DateTime bonusTime)
            {
                return $"Time of bonus: {bonusTime}";
            }
       }
 }

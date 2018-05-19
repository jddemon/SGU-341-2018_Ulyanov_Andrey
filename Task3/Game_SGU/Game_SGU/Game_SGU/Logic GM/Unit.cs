﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_SGU.Logic_GM
{
    public abstract class Unit
    {
        public Unit(int health, Point position)
        {
            this.Health = health;
            this.Position = position;
        }

        public int Health { get; set; }
        public Point Position { get; set; }

        public abstract Point Move(Point move);
    }
}

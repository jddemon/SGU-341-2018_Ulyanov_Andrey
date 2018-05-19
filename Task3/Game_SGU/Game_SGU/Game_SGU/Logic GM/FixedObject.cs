using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_SGU.Logic_GM
{
    public abstract class FixedObject
    {
        protected FixedObject(Point position)
        {
            this.Position = position;
        }

        public Point Position { get; set; }
    }
}

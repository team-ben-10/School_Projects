using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben
{
    abstract class Gebäude
    {
        protected static Random rnd = new Random();
        public Position pos;

        public Gebäude(Position pos)
        {
            this.pos = pos;
        }

        public abstract void MussErdbeben(float distance);
        public void OnErdbeben(object sender, EventArgs args)
        {
            MussErdbeben(Position.getDistance(((GebäudeEventArgs)args).pos, pos));
        }
    }
}

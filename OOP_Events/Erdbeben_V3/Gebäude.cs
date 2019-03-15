using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdbeben_V3
{
    abstract class Gebäude : IFeldInteraktion
    {
        protected static Random rnd = new Random();
        public Position pos;

        public abstract event EventHandler Callback;

        public Gebäude(Position pos)
        {
            this.pos = pos;
        }

        public void OnErdbeben(object sender, EventArgs args)
        {
            MussErdbeben(Position.getDistance(((GebäudeEventArgs)args).pos, pos));
        }
        public abstract void MussErdbeben(float distance);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdbeben_V3
{
    class Auto : IFeldInteraktion
    {
        public event EventHandler Callback;

        static Random rnd = new Random();

        public Position pos;

        public Auto(Position pos)
        {
            this.pos = pos;
        }

        public void OnErdbeben(object sender, EventArgs args)
        {

        }
        public void OnAutoRufen(object sender, EventArgs args)
        {
            var gArgs = (GebäudeEventArgs)args;
            var isOnPos = Position.getDistance(pos, gArgs.pos) == 0;
            if (isOnPos)
            {
                if(rnd.Next(0,101) <= 80)
                {
                    Callback?.Invoke(this, new CallbackArgs(pos, "Auto " + pos + " nimmt Person mit"));
                }
            }
        }
    }
}

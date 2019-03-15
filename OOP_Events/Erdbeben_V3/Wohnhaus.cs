using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdbeben_V3
{
    class Wohnhaus : Gebäude
    {
        public Wohnhaus(Position pos): base(pos) { }

        public override event EventHandler Callback;

        public override void MussErdbeben(float distance)
        {
            if(distance < 7)
            {
                if(rnd.Next(1,101) <= 50)
                {
                    Callback?.Invoke(this, new CallbackArgs(pos, GetType().Name + ": " + pos + " (Distance: " + distance + ")"));
                }
            }
        }
    }
}

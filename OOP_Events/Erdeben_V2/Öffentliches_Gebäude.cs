﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben_V2
{
    class Öffentliches_Gebäude : Gebäude
    {
        public Öffentliches_Gebäude(Position pos) : base(pos) { }

        public override event EventHandler Callback;

        public override void MussErdbeben(float distance)
        {
            if (distance < 6)
            {
                if (rnd.Next(1, 101) <= 30)
                {
                    Callback?.Invoke(this, new CallbackArgs(pos, GetType().Name + ": " + pos + " (Distance: " + distance + ")"));
                }
            }
        }
    }
}

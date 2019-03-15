using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben
{
    class Wohnhaus : Gebäude
    {
        public Wohnhaus(Position pos): base(pos) { }
        public override void MussErdbeben(float distance)
        {
            if(distance < 7)
            {
                if(rnd.Next(1,101) <= 50)
                {
                    Console.WriteLine(GetType().Name + ": " + pos + " (Distance: " +  distance + ")");
                }
            }
        }
    }
}

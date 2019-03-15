using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben
{
    class Öffentliches_Gebäude : Gebäude
    {
        public Öffentliches_Gebäude(Position pos) : base(pos) { }
        public override void MussErdbeben(float distance)
        {
            if (distance < 6)
            {
                if (rnd.Next(1, 101) <= 30)
                {
                    Console.WriteLine(GetType().Name.Replace("_", " ") + ": " + pos + " (Distance: " + distance + ")");
                }
            }
        }
    }
}

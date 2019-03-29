using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class MyEventArgs : EventArgs
    {
        public static Random rnd = new Random();

        public int Temp { get { return rnd.Next(18, 36); } private set { } }
        public int Luftfeucht { get { return rnd.Next(0, 101); } private set { } }

        public override string ToString()
        {
            return "Temp: " + Temp + " | " + "Luftfeucht: " + Luftfeucht;
        }
    }
}

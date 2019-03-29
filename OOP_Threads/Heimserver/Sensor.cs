using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Sensor
    {

        public Pos pos;
        static Random rnd = new Random();

        public enum Pos
        {
            Wohnzimmer, Küche, Bad
        }

        public Sensor(Pos pos)
        {
            this.pos = pos;
        }

        public MyEventArgs SendData()
        {
            Thread.Sleep(rnd.Next(1000, 5001));
            MyEventArgs myArgs = new MyEventArgs(pos);
            return myArgs;
        }
    }
}
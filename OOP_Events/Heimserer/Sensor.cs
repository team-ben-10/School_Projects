using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Sensor
    {
        public event EventHandler<MyEventArgs> sendToReceiver;
        public Pos pos;

        public enum Pos
        {
            Wohnzimmer, Küche, Bad
        }

        public Sensor(Pos pos)
        {
            this.pos = pos;
        }

        public void SendData()
        {
            MyEventArgs myArgs = new MyEventArgs();
            sendToReceiver(this, myArgs);
        }
    }
}
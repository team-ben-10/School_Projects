using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Heimserver
    {
        delegate void RequestData();
        private event RequestData request;

        public void NewSensor(Sensor sensor)
        {
            request += sensor.SendData;
            sensor.sendToReceiver += ReceiveData;
        }
        public void ReceiveData(object sender, EventArgs args)
        {
            MyEventArgs myargs = (MyEventArgs)args;
            Console.WriteLine(myargs + " | Position: " + ((Sensor)sender).pos);
        }
        public void Start()
        {
            request.BeginInvoke(null, null);
        }
    }
}

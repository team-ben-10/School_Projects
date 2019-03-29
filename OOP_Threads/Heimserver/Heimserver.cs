using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Heimserver
    {
        delegate MyEventArgs RequestData();
        private event RequestData request;
        int Done = 0;
        int Count = 0;
        public void Start()
        {
            while(Done < Count)
            {
            }
        }

        public void NewSensor(Sensor sensor)
        {
            request = sensor.SendData;
            Count++;
            var result = request.BeginInvoke(new AsyncCallback(ReceiveData), null);
        }
        public void ReceiveData(IAsyncResult result)
        {
            var callback = (AsyncResult)result;
            var delg = (RequestData)callback.AsyncDelegate;
            var data = delg.EndInvoke(result);
            Console.WriteLine(data + " | Position: " + data.pos);
            Done++;
        }

    }
}

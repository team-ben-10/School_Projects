using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alarm
{
    class Program
    {
        static Alarm alarm = new Alarm();

        static void Main(string[] args)
        {
            alarm.Start();
        }

    }

    class Alarm
    {
        delegate void alamieren(int time);
        static alamieren Alamieren;
        public void Start()
        {
            Alamieren = Wait;
            Console.Write("Läuten nach: ");
            var async = Alamieren.BeginInvoke((int)(float.Parse(Console.ReadLine())*1000), null, null);
            while (!async.IsCompleted) { };
        }

        public void Wait(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("ALARM");
        }
    }
}

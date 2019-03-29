using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Heimserver s = new Heimserver();
            Sensor s1 = new Sensor(Sensor.Pos.Bad);
            Sensor s2 = new Sensor(Sensor.Pos.Wohnzimmer);
            Sensor s3 = new Sensor(Sensor.Pos.Küche);
            s.NewSensor(s1);
            s.NewSensor(s2);
            s.NewSensor(s3);
            s.Start();
        }
    }
}

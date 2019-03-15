using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeburtenSimulation
{
    class Geburtsstation
    {
        public event EventHandler<GeburtsDaten> GeburtMelden;
        public List<GeburtsDaten> geboreneKinder = new List<GeburtsDaten>();
        static Random rnd = new Random();
        public string Bundesland;

        public Geburtsstation(string bundesland)
        {
            Bundesland = bundesland;
            new Thread(() =>
            {
                var geburtsProzent = GeburtWahrscheinlichkeit.getPercent(Bundesland);
                Console.WriteLine(geburtsProzent + ": " + bundesland);
                DateTime start = new DateTime(2016, 1, 1);
                for (DateTime dt = start; dt < start.AddYears(1); dt = dt.AddMinutes(5))
                {
                    if (rnd.NextDouble()*100 < geburtsProzent)
                    {
                        geboreneKinder.Add(new GeburtsDaten(Bundesland));
                        Console.WriteLine("Geburt!");
                    }
                    Thread.Sleep(500);
                }
            }).Start();
        }

        public void Geburt()
        {
            foreach (var item in geboreneKinder)
            {
                GeburtMelden?.Invoke(this, item);
                geboreneKinder = new List<GeburtsDaten>();
            }
        }
    }
}

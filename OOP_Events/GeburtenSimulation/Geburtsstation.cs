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
        static Random rnd = new Random();
        public string Bundesland;

        public Geburtsstation(string bundesland)
        {
            Bundesland = bundesland;
        }

        public void Geburt()
        {
            var prozent = GeburtWahrscheinlichkeit.getPercent(Bundesland);
            var cProzent = rnd.Next(0, 1000000001) / 10000000;
            Console.WriteLine("" + cProzent);
            if (cProzent <= prozent)
            {
                GeburtMelden?.Invoke(this, new GeburtsDaten(Bundesland));
            }
        }
    }
}

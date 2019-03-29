using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    class Geburtenstation
    {

        Random rnd = new Random();

        public string Bundesland;

        List<Baby> babies = new List<Baby>();

        public event EventHandler<Baby> KindGeboren;

        public Geburtenstation(string bundesland)
        {
            Bundesland = bundesland;
        }

        public void Geburt()
        {
            var i = GeburtenWahrscheinlichkeit.getPercent(Bundesland);
            if (rnd.Next(0, 101) <= i)
            {
                KindGeboren?.Invoke(this, new Baby(Bundesland));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    class Meldestelle
    {

        delegate void Anfrage();
        Anfrage GebAnfrage;
        int sum = 0;

        List<Geburtenstation> geburtenstationen = new List<Geburtenstation>();

        public Meldestelle()
        {
            this.geburtenstationen.Add(new Geburtenstation("Wien"));
            this.geburtenstationen.Add(new Geburtenstation("Niederösterreich"));
            this.geburtenstationen.Add(new Geburtenstation("Burgenland"));
            this.geburtenstationen.Add(new Geburtenstation("Oberösterreich"));
            this.geburtenstationen.Add(new Geburtenstation("Tirol"));
            this.geburtenstationen.Add(new Geburtenstation("Vorarlberg"));
            this.geburtenstationen.Add(new Geburtenstation("Salzburg"));
            this.geburtenstationen.Add(new Geburtenstation("Steiermark"));
            this.geburtenstationen.Add(new Geburtenstation("Kärnten"));
            foreach (var item in geburtenstationen)
            {
                GebAnfrage += item.Geburt;
                item.KindGeboren += Geburt;
            }
        }

        public void GeburtenAnfrage()
        {
            GebAnfrage?.Invoke();
        }

        public void Geburt(object sender, Baby args)
        {
            Console.WriteLine(args + " " + sum);
            sum++;
        }

        public void Start()
        {
            DateTime start = new DateTime(2016, 1, 1);
            for (DateTime dt = start; dt < start.AddYears(1); dt = dt.AddMinutes(5))
            {
                GeburtenAnfrage();
                //System.Threading.Thread.Sleep(5000);
            }
        }
    }
}

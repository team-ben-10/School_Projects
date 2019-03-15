using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeburtenSimulation
{
    class Meldestelle
    {
        public string[] bundesLänder = { "Niederösterreich", "Oberösterreich", "Wien", "Tirol", "Vorarlberg", "Steiermark", "Kärnten", "Salzburg", "Burgenland" };
        public delegate void Anfrage();
        public Anfrage GeburtAnfrage;
        public List<Geburtsstation> stationen = new List<Geburtsstation>();
        public int SummeAllerGeburten = 0;

        public Meldestelle()
        {
            foreach (var land in bundesLänder)
            {
                var station = new Geburtsstation(land);
                station.GeburtMelden += GeburtMelden;
                GeburtAnfrage += station.Geburt;
                stationen.Add(station);
            }
        }

        public void Run()
        {
            DateTime start = new DateTime(2016, 1, 1);
            for (DateTime dt = start; dt < start.AddYears(1); dt = dt.AddMinutes(5)) {
                GeburtenAnfragen();
                Console.WriteLine("Anfrage an die Stationen");
                System.Threading.Thread.Sleep(5000);
            }
            Console.WriteLine("Jahr ist rum!");
        }

        public void GeburtenAnfragen()
        {
            GeburtAnfrage?.Invoke();
        }

        public void GeburtMelden(object sender, GeburtsDaten daten)
        {
            Console.WriteLine(daten);
            SummeAllerGeburten++;
            Console.WriteLine("Summe aller Geburten: " + SummeAllerGeburten);
        }
    }
}

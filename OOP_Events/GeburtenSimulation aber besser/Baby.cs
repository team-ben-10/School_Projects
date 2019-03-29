using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    class Baby : EventArgs
    {
        static Random rnd = new Random();
        public string Name;
        public char Geschlecht;
        public DateTime Geburtszeitpunkt;
        public string Bundesland;

        public Baby(string bundesland)
        {
            if (rnd.Next(0, 2) == 0)
            {
                Geschlecht = 'M';
                Name = Names.GetRndMale();
            }
            else
            {
                Geschlecht = 'W';
                Name = Names.GetRndFemale();
            }
            Geburtszeitpunkt = DateTime.Now;
            Bundesland = bundesland;
        }
        public override string ToString()
        {
            return Name + " [" + Geschlecht + "] |" + Geburtszeitpunkt + " | " + Bundesland; 
        }
    }
}

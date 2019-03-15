using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeburtenSimulation
{
    class GeburtsDaten : EventArgs
    {
        static Random rnd = new Random();
        public string Name;
        public char Geschlecht;
        public DateTime Geburtszeitpunkt;
        public string Geburtsstation;

        public GeburtsDaten(string bundesland)
        {
            Geburtsstation = bundesland;
            if (rnd.Next(0, 2) == 0)
            {
                Geschlecht = 'W';
                Name = Names.GetRandomMaleName();
            }
            else
            {
                Geschlecht = 'M';
                Name = Names.GetRandomFemaleName();
            }
            Geburtszeitpunkt = DateTime.Now;
        }

        public override string ToString()
        {
            return Name + " [" + Geschlecht + "] " + Geburtszeitpunkt + " " + Geburtsstation; 
        }
    }

    public static class Names
    {
        static List<string> Mnames = new List<string>();
        static List<string> Fnames = new List<string>();
        static Random rnd = new Random();

        public static void Init()
        {
            using (var reader = new StreamReader("MaleNames.txt"))
            {
                while(!reader.EndOfStream)
                {
                    var splits = reader.ReadLine().Split(';');
                    foreach (var item in splits)
                    {
                        Mnames.Add(item);
                    }
                }
            }
            using (var reader = new StreamReader("FemaleNames.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var splits = reader.ReadLine().Split(';');
                    foreach (var item in splits)
                    {
                        Fnames.Add(item);
                    }
                }
            }
        }
        public static string GetRandomMaleName()
        {
            return Mnames[rnd.Next(0, Mnames.Count)];
        }
        public static string GetRandomFemaleName()
        {
            return Fnames[rnd.Next(0, Fnames.Count)];
        }
    }
}

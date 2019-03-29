using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aufgabe_4
{
    static class Names
    {
        public static Random rnd = new Random();
        public static List<string> Fname = new List<string>();
        public static List<string> Mname = new List<string>();

        public static void names()
        {
            StreamReader sr = new StreamReader("MaleNames.txt");

            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                foreach (var item in s)
                {
                    Mname.Add(item);
                }
            }
            sr.Close();
            sr = new StreamReader("FemaleNames.txt");

            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                foreach (var item in s)
                {
                    Fname.Add(item);
                }
            }
            sr.Close();
        }
        public static string GetRndMale()
        {
            return Mname[rnd.Next(0, Mname.Count-1)];
        }
        public static string GetRndFemale()
        {
            return Fname[rnd.Next(0, Fname.Count-1)];
        }
    }
}

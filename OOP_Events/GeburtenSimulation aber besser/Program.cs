using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Names.names();
            Meldestelle m = new Meldestelle();
            m.Start();
        }
    }
}

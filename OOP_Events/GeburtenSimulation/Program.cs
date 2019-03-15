using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeburtenSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Names.Init();
            Meldestelle meldestelle = new Meldestelle();
            meldestelle.Run();
        }
    }
}

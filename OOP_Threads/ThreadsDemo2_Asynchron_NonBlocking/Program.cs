using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsDemo2_Asynchron_NonBlocking
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulator s = new Simulator();
            s.go();
        }
    }
}

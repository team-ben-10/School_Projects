using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsDemo3_Asynchron_NonBlocking_Callback
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

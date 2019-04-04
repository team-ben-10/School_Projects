using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo4_ThreadMethod
{
    class Program
    {
        // This is just an example for starting multiple threads successfully WITHOUT parameters

        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {  // Start 10 Threads
                HelloThread h = new HelloThread(i);  // THIS ONE DOES NOT REACT ON PARAMETER i !!!
                Thread t = new Thread(h.go);
                t.Start();
            }
            Console.WriteLine("Yeah - 10 Threads running in the Background!");
            Console.ReadKey();
        }
    }
}

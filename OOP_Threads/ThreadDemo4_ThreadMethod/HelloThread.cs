using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo4_ThreadMethod
{
    public class HelloThread
    {
        private int threadNr; 

        public HelloThread(int t)
        {
            this.threadNr = t;   
        }

        public void go()
        {
            Console.WriteLine("Thread:" + threadNr + " started!");  // threadNr always 0!
            Thread.Sleep(1000);
            Console.WriteLine("Thread:"+threadNr+" finished!");
        }
    }
}

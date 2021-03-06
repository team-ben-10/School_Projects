﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo4_ThreadMethod_WithParams
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {  // Start 10 Threads
                HelloThread h = new HelloThread();  
                Params ap = new Params(i);  // Construct Params

                Thread t = new Thread(new ParameterizedThreadStart(h.go));
                t.Start(ap);  // Start Thread with Params
            }
            Console.WriteLine("Yeah - 10 Threads running in the Background!");
            Console.ReadKey();
        }
    }
}

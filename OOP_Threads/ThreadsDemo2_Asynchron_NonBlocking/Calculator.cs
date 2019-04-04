using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsDemo2_Asynchron_NonBlocking
{
    public class Calculator
    {

        public float add(int a,int b,int sleeptime)
        {
            Thread.Sleep(sleeptime);
            return a + b;
        }


        public float sub(int a, int b, int sleeptime)
        {
            Thread.Sleep(sleeptime);
            return a - b;

        }
    }
}

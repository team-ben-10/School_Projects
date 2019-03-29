using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsDemo1
{
    public class Calculator
    {

        public float add(int a,int b,int sleeptime)
        {
            Thread.Sleep(sleeptime);
            return a + b;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo4_ThreadMethod_WithParams
{
    public class HelloThread
    {
      

        public void go(object data)
        {
            if (data is Params) { 
                Console.WriteLine("Thread:" + (data as Params).a + " started!");  
                Thread.Sleep(1000);
                Console.WriteLine("Thread:" + (data as Params).a + " finished!");
            }
        }
    }
}

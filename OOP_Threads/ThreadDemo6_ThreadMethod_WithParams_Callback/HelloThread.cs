using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo6_ThreadMethod_WithParams_Callback
{
    class HelloThread
    {
        public delegate void Finished(String s);
        public event Finished EFinished;

        public void go(object data)
        {
            if (data is Params)
            {
                Console.WriteLine("Thread:" + (data as Params).a + " started!");
                
                for (int x=0;x<3;x++) {
                    Thread.Sleep(1000);
                    EFinished?.Invoke("Thread:" + (data as Params).a + " finished!");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsDemo3_Asynchron_NonBlocking_Callback
{
    public class Simulator
    {
        private Calculator calculator = new Calculator();
        private delegate float Operation(int a,int b,int sleeptime);
        private Operation operation1, operation2;
        private int isDone = 0;

        public void go()
        {
            Console.WriteLine("Main() invoked on thread {0}.",Thread.CurrentThread.ManagedThreadId);

            // Calling first async Delegate --> will finish later
                operation1 = calculator.add;
                Console.Write("Calling first Thread-->"); 
                IAsyncResult async1 = operation1.BeginInvoke(10, 10,5000, new AsyncCallback(CalculationFinished), "10 + 10 ergibt:");
                Console.WriteLine("First Job started without blocking the program!");

            // Calling second async Delegate --> will finish earlier
                operation2 = calculator.sub;
                Console.Write("Calling second Thread-->"); 
                IAsyncResult async2 = operation2.BeginInvoke(10, 5, 3000, new AsyncCallback(CalculationFinished), "10 - 5 ergibt:");
                Console.WriteLine("Second Job started without blocking the program!");
            
        

            // Do some work while waiting for result
            while (isDone<2)
            {
                Console.WriteLine("Doing more work in Main()!");
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

        // CALLBACK METHOD WHEN FINISHED !!
        private void CalculationFinished(IAsyncResult ar)
        {
            // Now get the result.
            AsyncResult ar_result = (AsyncResult)ar;
            Operation o = (Operation)ar_result.AsyncDelegate;

            string msg = (string)ar.AsyncState;
            Console.Write(msg); // get Message which has been set as second parameter when calling the thread
            Console.WriteLine("{0}.", o.EndInvoke(ar_result));
            isDone++;
        }
    }
}

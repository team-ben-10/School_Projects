using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsDemo2_Asynchron_NonBlocking
{
    public class Simulator
    {
        private Calculator calculator = new Calculator();
        private delegate float Operation(int a,int b,int sleeptime);
        private Operation operation1, operation2;

        public void go()
        {
            Console.WriteLine("Main() invoked on thread {0}.",Thread.CurrentThread.ManagedThreadId);

            // Calling first async Delegate --> will finish later
                operation1 = calculator.add;
                Console.Write("Calling first Thread-->"); 
                IAsyncResult async1 = operation1.BeginInvoke(10, 10,5000, null, null);
                Console.WriteLine("First Job started without blocking the program!");

            // Calling second async Delegate --> will finish earlier
                operation2 = calculator.sub;
                Console.Write("Calling second Thread-->"); 
                IAsyncResult async2 = operation2.BeginInvoke(10, 5, 3000, null, null);
                Console.WriteLine("Second Job started without blocking the program!");


            // Do some work while waiting for result
            /*
                while (!async2.IsCompleted)
                {
                    Console.WriteLine("Doing more work in Main()!");
                    Thread.Sleep(1000);
                }
                */

            // Get the result of second calculation(sub) method when ready.
                float answer2 = operation2.EndInvoke(async2);
                Console.WriteLine("10 - 10 is {0}.", answer2);


            // Do some work while waiting for result
            while (!async1.IsCompleted)
            {
                Console.WriteLine("Doing more work in Main()!");
                Thread.Sleep(1000);
            }


            // Get the result of first calculation(add) method when ready.
            float answer1 = operation1.EndInvoke(async1);
            Console.WriteLine("10 + 10 is {0}.", answer1);


            // These lines will not execute until the add() method has completed.
                Console.WriteLine("Uh, waiting for the result ist blocking again!!");
                Console.ReadLine();
        }

    }
}

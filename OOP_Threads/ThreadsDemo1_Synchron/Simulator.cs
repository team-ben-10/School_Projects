using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsDemo1
{
    public class Simulator
    {
        private Calculator calculator = new Calculator();
        private delegate float Operation(int a,int b,int sleeptime);
        private Operation operation;

        public void go()
        {
            operation += calculator.add;
            

            Console.WriteLine("Starting calculation..");
            float answer = operation(10, 10,2000);  // Synchronious operation (blocks until finished)

            // These lines will not execute until the add() method has completed.
            Console.WriteLine("Doing more work in Main()!");
            Console.WriteLine("10 + 10 is {0}.", answer);
            Console.ReadLine();
        }

    }
}

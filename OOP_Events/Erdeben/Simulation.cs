using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben
{
    class Simulation
    {
        public void Start()
        {
            Stadt stadt1 = new Stadt();
            foreach (var item in stadt1.plätze)
            {
                if (item != null)
                    stadt1.OnErdbeben += item.OnErdbeben;
            }
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (stadt1.plätze[x, y] != null)
                        Console.Write(stadt1.plätze[x, y]?.GetType().Name[0]);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        stadt1.ErdbebenAuslösen();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdbeben_V3
{
    class Simulation
    {
        public void Start()
        {
            Stadt stadt1 = new Stadt();
            foreach (var item in stadt1.plätze)
            {
                if (item != null)
                {
                    stadt1.OnErdbeben += item.OnErdbeben;
                    item.Callback += stadt1.OnCallback;
                    if (item is Person)
                        stadt1.FeuerwehrRufen += ((Person)item).FeuerwehrRufen;
                    if (item is Auto)
                        stadt1.AutoRufen += ((Auto)item).OnAutoRufen;
                }
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

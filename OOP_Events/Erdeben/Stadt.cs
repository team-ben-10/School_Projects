﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben
{
    class Stadt
    {
        static Random rnd = new Random();
        public event EventHandler OnErdbeben;
        public Gebäude[,] plätze = new Gebäude[10,10];

        public Stadt()
        {
            for (int i = 0; i < 5; i++)
            {
                Position pos = new Position(rnd.Next(0, 10), rnd.Next(0, 10));
                if (plätze[pos.x, pos.y] == null)
                    plätze[pos.x, pos.y] = new Wohnhaus(pos);
                else
                    i--;
            }
            for (int i = 0; i < 5; i++)
            {
                Position pos = new Position(rnd.Next(0, 10), rnd.Next(0, 10));
                if (plätze[pos.x, pos.y] == null)
                    plätze[pos.x, pos.y] = new Öffentliches_Gebäude(pos);
                else
                    i--;
            }
        }

        public void ErdbebenAuslösen()
        {
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);
            Position pos = new Position(x, y);
            OnErdbeben?.Invoke(this, new GebäudeEventArgs(pos));
        }
    }

    class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public static float getDistance(Position pos1, Position pos2)
        {
            return (float)Math.Sqrt((Math.Pow((pos2.x - pos1.x), 2) + Math.Pow((pos2.y - pos1.y), 2)));
        }

        public override string ToString()
        {
            return "[" + x + ", " + y + "]";
        }
    }

}
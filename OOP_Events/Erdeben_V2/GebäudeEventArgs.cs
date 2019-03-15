using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben_V2
{
    class GebäudeEventArgs : EventArgs
    {
        public Position pos;
        public GebäudeEventArgs(Position pos)
        {
            this.pos = pos;
        }
    }
}

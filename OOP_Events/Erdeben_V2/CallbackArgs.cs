using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben_V2
{
    class CallbackArgs : EventArgs
    {
        public Position pos;
        public string outPut;

        public CallbackArgs(Position distance, string outPut)
        {
            this.pos = distance;
            this.outPut = outPut;
        }
    }
}

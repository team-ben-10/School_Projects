using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdeben_V2
{
    interface IFeldInteraktion
    {
        event EventHandler Callback;
        void OnErdbeben(object sender, EventArgs args);
        
    }
}

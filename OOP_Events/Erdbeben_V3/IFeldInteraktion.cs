using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erdbeben_V3
{
    interface IFeldInteraktion
    {
        event EventHandler Callback;
        void OnErdbeben(object sender, EventArgs args);
        
    }
}

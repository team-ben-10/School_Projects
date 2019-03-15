using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erdbeben_V3
{
    class Person : IFeldInteraktion
    {
        public event EventHandler Callback;
        public Position pos;

        public Person(Position pos)
        {
            this.pos = pos;
        }

        public void OnErdbeben(object sender, EventArgs args)
        {
            GebäudeEventArgs eArgs = (GebäudeEventArgs)args;
            float distance = Position.getDistance(pos, eArgs.pos);
            if (distance < 5)
                Callback(this, new CallbackArgs(pos, GetType().Name + ": " + pos + " (Distance: " + distance + ") ruft um Hilfe!"));
        }

        public void FeuerwehrRufen(object sender, EventArgs args)
        {
            GebäudeEventArgs eArgs = (GebäudeEventArgs)args;
            float distance = Position.getDistance(pos, eArgs.pos);
            if(distance < 2)
                Callback.Invoke(this, new CallbackArgs(pos, GetType().Name + ": " + pos + " (Distance: " + distance + ") ruft die Feuerwehr!"));
        }
    }
}

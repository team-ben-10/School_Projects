using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeburtenSimulation
{
    class GeburtWahrscheinlichkeit
    {
        static Dictionary<string/*location*/, int/*number of births per year*/> locationToBirths = new Dictionary<string, int>(){{ "Wien", 20988 },{ "Vorarlberg", 4341 },{ "Steiermark", 11299 },{ "Oberösterreich", 15495 },{ "Niederösterreich", 15475 },{ "Tirol", 7636 },{ "Salzburg", 5685 },{ "Kärnten", 4870 },{ "Burgenland", 2307 }};
        public static float getPercent(string name)
        {
            int sum = 0;
            foreach (var item in locationToBirths)
            {
                sum += item.Value;
            }
            return (((float)locationToBirths[name] / sum)/365/24/12)*100;
        }
    }
}

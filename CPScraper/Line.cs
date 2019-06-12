using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPScraper
{
    class Line
    {
        List<Tuple<string, string>> stops = new List<Tuple<string, string>>();

        public void AddStop(string name, string time)
        {
            stops.Add(Tuple.Create(name, time));
        }

        public Tuple<string, string> GetStop(int id)
        {
            return stops[id];
        }

        public int GetNumOfStops()
        {
            return stops.Count;
        }
    }
}

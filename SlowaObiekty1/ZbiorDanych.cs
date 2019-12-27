using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowaObiekty1
{
   class ZbiorDanych
    {
        public static List<Slowo> slowaStatic { get; set; }
        static ZbiorDanych()
        {
            slowaStatic = new List<Slowo>();
            slowaStatic.Add(new Slowo("stół", "table"));
            slowaStatic.Add(new Slowo("piłka", "ball"));
            slowaStatic.Add(new Slowo("lampa", "lamp"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowaObiekty1
{
    class Program
    {
        static void Main(string[] args)
        {
            Slownik moj = new Slownik();
            moj.SlownikDodaj("ksiazka", "book");
            moj.SlownikDodaj("rower", "bike");
            moj.SlownikDodaj("szkola", "school");

            moj.WypiszSlowa();
            moj.RandomSlowo();
            Console.ReadKey();

        }
    }
}

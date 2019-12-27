using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowaObiekty1
{
    class Slownik
    {
        public List<Slowo> slownik=new List<Slowo>();
        public int Punkty;

       
        public void SlownikDodaj( string slowoA, string slowoB)
        {
            //ID = id;
            //SlowoPolskie = slowoA;
            // SlowoAngielskie = slowoB;
            Slowo a = new Slowo(slowoA, slowoB);
            slownik.Add(a);
        }
        public void WypiszSlowa()
        {
            foreach (var n in slownik)
            {
                Console.WriteLine(n.SlowoPolskie+" - "+n.SlowoAngielskie);
            }
        }
        public void RandomSlowo()
        {
            var rand = new Random();
            int testnum = rand.Next(slownik.Count);
            Console.WriteLine(slownik[testnum].SlowoPolskie+" - ");
        }

        public Slowo RandomSlowoReturn()
        {
            var rand = new Random();
            int testnum = rand.Next(slownik.Count);
            return slownik[testnum];
        }

        public void TestSlowoEng(Slowo slowotest,string testslowo)
        {
            if (testslowo == slowotest.SlowoPolskie)
            {
                Console.WriteLine("Dobra odpowiedź");
                Punkty++;
            }
            else
            {
                Console.WriteLine("Zła odpowiedź. Prawidlowe tłumaczenie to " + slowotest.SlowoAngielskie);
            }
            
        }

        public void WyswietlPunktacje()
        {
            Console.WriteLine(Punkty);
        }
    }
}

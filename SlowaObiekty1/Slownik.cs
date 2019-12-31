using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowaObiekty1
{
    public class Slownik
    {
        // List<Slowo> slownik=new List<Slowo>();
        public List<Slowo> slownik = ZbiorDanych.slowaStatic; //statyczne źródło otwarte na dodawanie

        public int Punkty;
        public int Ilosc;
        public Slowo Testowe;



        public void SlownikDodaj(string slowoA, string slowoB)
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
                Console.WriteLine(n.SlowoPolskie + " - " + n.SlowoAngielskie);
            }
        }
        public void RandomSlowo()
        {
            var rand = new Random();
            int testnum = rand.Next(slownik.Count);
            Console.WriteLine(slownik[testnum].SlowoPolskie + " - ");
        }

        public Slowo RandomSlowoReturn()
        {
            if (Ilosc < 30) { 
            var rand = new Random();
            int testnum = rand.Next(slownik.Count);
            Testowe = slownik[testnum];
            Ilosc++;
            return Testowe;
            }
            else
            {
                Slowo OstSlowo = new Slowo("koniec przykładów","koniec przykladów");
                return OstSlowo;
            }
        }

        public void TestSlowoEng(Slowo slowotest, string testslowo)
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

        public string TestSlowoEngCheck(Slowo slowotest, string testslowo)
        {
            if (testslowo == slowotest.SlowoAngielskie)
            {
                Punkty++;
                return "Dobrze";
               
            }
            else
            {
                return "Źle," + " Prawidlowa odpowiedz to: "+Testowe.SlowoAngielskie;
            }

        }

        public void WyswietlPunktacje()
        {
            Console.WriteLine(Punkty);
        }

        public string WyswietlPunktyValue()
        {
            
            
            return "Wynik="+Punkty.ToString()+"/"+Ilosc.ToString();
        }

        public void UsunSlowo(string slowopol) //Mogę utworzyć nową listę, która nie zawiera słowa starą usunąć i z powrotem ją wypełnić słowami
        {
            List<Slowo> robocze = new List<Slowo>();

            foreach (var n in slownik)
            {
                if (n.SlowoPolskie != slowopol)
                {
                    robocze.Add(n);
                }
            }

            slownik.Clear();

            foreach (var m in robocze)
            {
                slownik.Add(m);
            }

        }
    }
}

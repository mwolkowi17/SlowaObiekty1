using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowaObiekty1
{
    public class Slowo
    {
        public int ID { get; set; }
        public string SlowoPolskie { get; set; }
        public string SlowoAngielskie { get; set; }

        public Slowo( int id,string slowopol, string slowoeng)
        {
            ID = id;
            SlowoPolskie = slowopol;
            SlowoAngielskie = slowoeng;
            
        }
        public Slowo(string slowopol, string slowoeng)
        {
            
            SlowoPolskie = slowopol;
            SlowoAngielskie = slowoeng;

        }
        
        public override string ToString()
        {
            return SlowoPolskie + " - " + SlowoAngielskie;
        }
    }
}

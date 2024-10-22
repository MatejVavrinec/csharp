using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obdlznik
{
    public class Obdlznik
    {
        public int sirka { get; set; }

        public int vyska { get; set; }
        public Obdlznik(int sirka, int vyska)
        {
            this.sirka = sirka;
            this.vyska = vyska;


        }
        public int Obsah()
        {
            return sirka * vyska;
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim
{
     public class Tim1
    {
        private string nazov { get; set; }
        private static int pocettimov = 0;

        public Tim1(string nazov)
        {
            this.nazov = nazov;
            ++pocettimov;
        }

        public static int ZiskajPocettimov()
        {
            return pocettimov;
        }
        public string ZiskajNazov()
        {
            return nazov;
        }
    }
}

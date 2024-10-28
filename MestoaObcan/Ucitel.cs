using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    internal class Ucitel
    {
        public string meno { get; set; }
        public int vek { get; set; }

        public Ucitel(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Meno: {meno}, Vek: {vek} uci ludi" );
        }

    }





}


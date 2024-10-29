using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    internal class Ucitel
    {
        public string menoucitela { get; set; }
        public int vekucitela { get; set; }

        public Ucitel(string meno, int vek)
        {
            this.menoucitela = meno;
            this.vekucitela = vek;
        }
        public void VypisInfo()
        {
            Console.WriteLine($"Meno: {menoucitela}, Vek: {vekucitela}, uci studentov");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    internal class Mechanik
    {
        public string menomechanika { get; set; }
        public int vekmechanika { get; set; }

        public Mechanik(string meno, int vek)
        {
            this.menomechanika = meno;
            this.vekmechanika = vek;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Meno: {menomechanika}, Vek: {vekmechanika}, opravuje auta");
        }




    }
}

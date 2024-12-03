using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    public class SeniorMechanik : Mechanik
    {
        protected int pocetProjektov;
        public SeniorMechanik(string meno, int vek, string typvozidla, int pocetProjektov) : base(meno, vek, typvozidla)
        {
            this.pocetProjektov = pocetProjektov;
        }

        public new void VypisInfo()
        {
            Console.WriteLine(meno + ", " + vek + "opravuje" + typvozidla + " a ma " + pocetProjektov + "projektov" + stav);
        }
        public SeniorMechanik()
        {
            
        }
    }
}

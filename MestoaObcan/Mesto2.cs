using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    internal class Mesto2
    {

        public string nazov { get; set; }
        public List<Mechanik> mechanici { get; set; }
        public List<Ucitel> ucitelia { get; set; }
        public List<Lekar> lekari { get; set; }

        public Mesto2(string nazov)
        {
            this.nazov = nazov;
            mechanici = new List<Mechanik>();
            this.nazov = nazov;
            ucitelia = new List<Ucitel>();
            this.nazov = nazov;
            lekari = new List<Lekar>();

        }

        public void PridajMechanika(Mechanik mechanik)
        {
            mechanici.Add(mechanik);
        }
        public void PridajUcitela(Ucitel ucitel)
        {
            ucitelia.Add(ucitel);
        }
        public void PridajLekara(Lekar lekar)
        {
            lekari.Add(lekar);
        }

        public void VypisObcanov()
        {
            Console.WriteLine($"Obcania mesta {nazov}:");
            foreach (var mechanik in mechanici)
            {
                mechanik.VypisInfo();
            }
            foreach (var ucitel in ucitelia)
            {
                ucitel.VypisInfo();
            }
            foreach (var lekar in lekari)
            {
                lekar.VypisInfo();
            }


        }


    }


}
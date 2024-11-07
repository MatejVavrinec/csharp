using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    public class Mesto
    {
        public string nazov { get; set; }
        public List <Obcan> obcania = new List<Obcan>();
        public List<Mechanik> mechanici = new List<Mechanik>();

        public Mesto(string nazov)
        {
            this.nazov = nazov;
            obcania = new List<Obcan>();
            mechanici = new List<Mechanik>();


        }
                
        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }
        public void PridajMechanika(Mechanik mechanik)
        {
            obcania.Add(mechanik);
        }

        public void VypisMechanikov()
        {
            Console.WriteLine($"Mechanici mesta {nazov}:");
            foreach (var mechanik in mechanici)
            {
                mechanik.VypisInfo();
            }
        }

        public void VypisObcanov()
        {
            Console.WriteLine($"Obcania mesta {nazov}:");
            foreach (var obcan in obcania)
            {
                obcan.VypisInfo();
            }
        }
    }
}
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
        public List <Obcan> obcania { get; set; }

        public Mesto(string nazov)
        {
            this.nazov = nazov;
            obcania = new List<Obcan>();

        }


        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }

        public void VypisObčanov()
        {
            Console.WriteLine($"Občania mesta {nazov}:");
            foreach (var obcan in obcania)
            {
                obcan.VypisInfo();
            }
        }
    }
}
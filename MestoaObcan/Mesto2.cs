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
        public List<Mechanik> obcania { get; set; }

        public Mesto2(string nazov)
        {
            this.nazov = nazov;
            obcania = new List<Mechanik>();

        }


        public void PridajMechanika(Mechanik mechanik)
        {
            obcania.Add(mechanik);
        }




        public void VypisMechanikou()
        {
            Console.WriteLine($"Občania mesta {nazov}:");
            foreach (var obcan in obcania)
            {
                obcan.VypisInfo();
            }
        }
    }
}
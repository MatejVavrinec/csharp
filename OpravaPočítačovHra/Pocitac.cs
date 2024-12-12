using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravaPocitacovHra
{
    internal class Pocitac
    {
        public Component CPU { get; set; }
        public Component RAM { get; set; }
        public Component GPU { get; set; }
        public Component HDD { get; set; }

        public Pocitac()
        {
            CPU = new CPU();
            RAM = new RAM();
            GPU = new GPU();
            HDD = new HDD();
        }

        public void StavPC()
        {
            Console.WriteLine("\nStav Pocitaca");
            Console.WriteLine($"CPU: {CPU.Stav}");
            Console.WriteLine($"RAM: {RAM.Stav}");
            Console.WriteLine($"GPU: {GPU.Stav}");
            Console.WriteLine($"HDD: {HDD.Stav}");
        }
        public bool NahraditKomponent(Component novyComponent)
        {
            if (novyComponent is CPU)
            {
                if (!CPU.Funguje)
                {
                    CPU = novyComponent;
                    return true;
                }
            }
            else if (novyComponent is RAM)
            {
                if (!RAM.Funguje)
                {
                    RAM = novyComponent;
                    return true;
                }
            }
            else if (novyComponent is GPU)
            {
                if (!GPU.Funguje)
                {
                    GPU = novyComponent;
                    return true;
                }
            }
            else if (novyComponent is HDD)
            {
                if (!HDD.Funguje)
                {
                    HDD = novyComponent;
                    return true;
                }
            }
            return false;
        }

    }
}

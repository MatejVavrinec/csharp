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
        public List<Component> CPUs { get; set; } = new List<Component> { };
        public List<Component> RAMs { get; set; } = new List<Component> { };
        public List<Component> GPUs { get; set; } = new List<Component> { };
        public List<Component> HDDs { get; set; } = new List<Component> { };

        
        public Pocitac()
        {
            Random r = new Random();

            CPU pouziteCPU = new CPU();
            pouziteCPU.Funguje = r.Next(4) == 0;
            RAM pouzitaRAM = new RAM();
            pouziteCPU.Funguje = r.Next(4) == 0;
            GPU pouziteGPU = new GPU();
            pouziteCPU.Funguje = r.Next(4) == 0;
            HDD pouziteHDD = new HDD();
            pouziteCPU.Funguje = r.Next(4) == 0;
            CPUs.Add(pouziteCPU);
            RAMs.Add(pouzitaRAM);
            GPUs.Add(pouziteGPU);
            HDDs.Add(pouziteHDD);
        }

        public void StavPC()
        {
            Console.WriteLine("\nStav počítača:");
            UkazListKomponentov("CPU", CPUs);
            UkazListKomponentov("RAM", RAMs);
            UkazListKomponentov("GPU", GPUs);
            UkazListKomponentov("HDD", HDDs);
        }

        private void UkazListKomponentov(string meno, List<Component> components)
        {
            Console.WriteLine($"\n{meno}s:");
            for (int i = 0; i < components.Count; i++)
            {
                Console.WriteLine($"  {meno} {i + 1}: {components[i].Stav}");
            }
        }

        public void PridajKomponent(Component component)
        {
            if (component is CPU) CPUs.Add(component);
            else if (component is RAM) RAMs.Add(component);
            else if (component is GPU) GPUs.Add(component);
            else if (component is HDD) HDDs.Add(component);
        }
        

        
    }
}
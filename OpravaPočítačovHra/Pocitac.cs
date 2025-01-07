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
        public List<Component> CPUs { get; set; }
        public List<Component> RAMs { get; set; }
        public List<Component> GPUs { get; set; }
        public List<Component> HDDs { get; set; }

        public Pocitac()
        {
            CPUs = new List<Component> { new CPU() };
            RAMs = new List<Component> { new RAM() };
            GPUs = new List<Component> { new GPU() };
            HDDs = new List<Component> { new HDD() };
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravaPocitacovProgram
{
    public class Pocitac
    {

        public List<Component> Components { get; set; }

        public Pocitac()
        {
            Components = VygenerujNahodnyKomponent();
        }

        private List<Component> VygenerujNahodnyKomponent()
        {
            var rand = new Random();

            // Náhodný výber z každej kategórie
            var cpus = new List<Component>
        {
            new CPU("Intel Core i5-12400", 150, "6 jadier, 12 vlákien, 2.5 GHz"),
            new CPU("AMD Ryzen 5 5600X", 200, "6 jadier, 12 vlákien, 3.7 GHz"),
            new CPU("Intel Core i7-12700K", 300, "12 jadier, 20 vlákien, 3.6 GHz")
        };

            var rams = new List<Component>
        {
            new RAM("Corsair Vengeance LPX", 80, "16GB, 3200 MHz"),
            new RAM("G.Skill Trident Z RGB", 150, "32GB, 3600 MHz"),
            new RAM("Kingston Fury Beast", 300, "64GB, 4000 MHz")
        };

            var gpus = new List<Component>
        {
            new GPU("NVIDIA GeForce GTX 1660", 250, "6GB GDDR5"),
            new GPU("AMD Radeon RX 6700 XT", 400, "12GB GDDR6"),
            new GPU("NVIDIA GeForce RTX 3080", 800, "10GB GDDR6X")
        };

            var hdds = new List<Component>
        {
            new HDD("Seagate Barracuda", 50, "1TB, 7200 RPM"),
            new HDD("Samsung 970 EVO Plus", 120, "1TB, NVMe SSD"),
            new HDD("WD Black SN850", 300, "2TB, PCIe Gen4 SSD")
        };

            // Generovanie jedného komponentu z každej kategórie
            var componenty = new List<Component>
        {
            new Component(cpus[rand.Next(cpus.Count)]) { Funguje = rand.Next(2) == 1 },
            new Component(rams[rand.Next(rams.Count)]) { Funguje = rand.Next(2) == 1 },
            new Component(gpus[rand.Next(gpus.Count)]) { Funguje = rand.Next(2) == 1 },
            new Component(hdds[rand.Next(hdds.Count)]) { Funguje = rand.Next(2) == 1 }
        };

            return componenty;
        }

        public bool PlneFunguje() => Components.All(c => c.Funguje);

        public void UkazStatus()
        {
            foreach (var component in Components)
            {
                Console.WriteLine($"- {component.Meno} ({component.Specifikacie}) - {component.Stav}");
            }
        }
    }

}

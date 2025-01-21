using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravaPocitacovProgram
{
    public class Obchod
    {
        public List<Component> Components { get; set; }

        public Obchod()
        {
            Components = new List<Component>
        {
            new CPU("Intel Core i5-12400", 150, "6 jadier, 12 vlakien, 2.5 GHz"),
            new CPU("AMD Ryzen 5 5600X", 200, "6 jadier, 12 vlakien, 3.7 GHz"),
            new CPU("Intel Core i7-12700K", 300, "12 jadier, 20 vlakien, 3.6 GHz"),
            new RAM("Corsair Vengeance LPX", 80, "16GB, 3200 MHz"),
            new RAM("G.Skill Trident Z RGB", 150, "32GB, 3600 MHz"),
            new RAM("Kingston Fury Beast", 300, "64GB, 4000 MHz"),
            new GPU("NVIDIA GeForce GTX 1660", 250, "6GB GDDR5"),
            new GPU("AMD Radeon RX 6700 XT", 400, "12GB GDDR6"),
            new GPU("NVIDIA GeForce RTX 3080", 800, "10GB GDDR6X"),
            new HDD("Seagate Barracuda", 50, "1TB, 7200 RPM"),
            new HDD("Samsung 970 EVO Plus", 120, "1TB, NVMe SSD"),
            new HDD("WD Black SN850", 300, "2TB, PCIe Gen4 SSD")
        };
        }

        public decimal PrezeratObchod(decimal budget, List<Component> inventar)
        {
            Console.WriteLine("\nObchod - Dostupne komponenty:");
            for (int i = 0; i < Components.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Components[i]}");
            }

            Console.WriteLine("\nZadaj cislo komponentu, ktory chces kupit, alebo stlac Enter pre navrat:");
            string volba = Console.ReadLine();

            if (int.TryParse(volba, out int index) && index > 0 && index <= Components.Count)
            {
                Component selected = Components[index - 1];
                if (budget >= selected.Cena)
                {
                    budget -= selected.Cena;
                    inventar.Add(new Component(selected)); // Pridávam novú kópiu komponentu
                    Console.WriteLine($"Kupil si {selected.Meno} za {selected.Cena:C}. Zostavajuci rozpocet: {budget:C}");
                }
                else
                {
                    Console.WriteLine("Nemas dostatok penazi na tento komponent!");
                }
            }

            Console.WriteLine("\nStlac Enter pre navrat...");
            Console.ReadLine();
            return budget;
        }
    }
}

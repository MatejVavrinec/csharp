using OpravaPocitacovHra;
using static System.Formats.Asn1.AsnWriter;

namespace OpravaPočítačovHra
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pocitac pocitac = new Pocitac();
            decimal budget = 500;
            bool gamerunning = true;
            

            
            while (gamerunning)
            {
                Console.Clear();
                Console.WriteLine($"Tvoj aktualny rozpocet je " + budget + " Eur");
                pocitac.StavPC();

                Console.WriteLine("\nCo chcete urobit");
                Console.WriteLine("1.Zakupit komponent");
                Console.WriteLine("2.Vymenit komponent");
                Console.WriteLine("3.Ukoncit hru");
                var answer = Console.ReadLine();

                




                switch (answer)
                {
                    case "1":
                        budget = KupitKomponent(pocitac, budget);
                        break;

                     case "2":
                        budget = ReplaceBrokenComponent(pocitac, budget);
                        break;

                    case "3":
                        gamerunning = false;
                        break;
                    default:
                        Console.WriteLine("Neplatna volba. Skus to znova.");
                        break;
                }
            }

            Console.WriteLine("Hra skoncila. Dakujem za hranie!");
        }

        static decimal KupitKomponent(Pocitac pocitac, decimal budget)
        {
            Console.WriteLine("\nAký komponent chceš kúpiť?");
            Console.WriteLine("1. CPU (100€)");
            Console.WriteLine("2. RAM (50€)");
            Console.WriteLine("3. GPU (150€)");
            Console.WriteLine("4. HDD (75€)");

            string volba = Console.ReadLine();
            Component novykomponent = null;
            int cena = 0;

            switch (volba)
            {
                case "1":
                    novykomponent = new CPU();
                    cena = 100;
                    break;
                case "2":
                    novykomponent = new RAM();
                    cena = 50;
                    break;
                case "3":
                    novykomponent = new GPU();
                    cena = 150;
                    break;
                case "4":
                    novykomponent = new HDD();
                    cena = 75;
                    break;
                default:
                    Console.WriteLine("Neplatna volba.");
                    return budget;
            }


            // Kontrola rozpočtu
            if (budget >= cena)
            {
                pocitac.PridajKomponent(novykomponent);
                budget -= cena; // Odpočítať cenu komponentu
                Console.WriteLine($"Komponent bol uspesne zakupeny. Zostavajuci rozpocet: {budget:C}");
            }
            else
            {
                Console.WriteLine("Nemas dostatok penazi na tento komponent!");
            }

            Console.WriteLine("\nStlac Enter pre pokracovanie...");
            Console.ReadLine();
            return budget;
        }
        static decimal ReplaceBrokenComponent(Pocitac pocitac, decimal budget)
        {
            Console.WriteLine("\nAký typ komponentu chceš vymeniť?");
            Console.WriteLine("1. CPU (100€)");
            Console.WriteLine("2. RAM (50€)");
            Console.WriteLine("3. GPU (150€)");
            Console.WriteLine("4. HDD (75€)");

            string choice = Console.ReadLine();
            List<Component> selectedList = null;
            decimal cost = 0;

            switch (choice)
            {
                case "1":
                    selectedList = pocitac.CPUs;
                    cost = 100;
                    break;
                case "2":
                    selectedList = pocitac.RAMs;
                    cost = 50;
                    break;
                case "3":
                    selectedList = pocitac.GPUs;
                    cost = 150;
                    break;
                case "4":
                    selectedList = pocitac.HDDs;
                    cost = 75;
                    break;
                default:
                    Console.WriteLine("Neplatná voľba.");
                    return budget;
            }

            // Nájsť prvý pokazený komponent na výmenu
            Component brokenComponent = selectedList.Find(c => !c.Funguje);

            if (brokenComponent != null)
            {
                if (budget >= cost)
                {
                    selectedList[selectedList.IndexOf(brokenComponent)] = CreateNewComponent(choice);
                    budget -= cost;
                    Console.WriteLine($"Pokazený komponent bol úspešne nahradený. Zostávajúci rozpočet: {budget:C}");
                }
                else
                {
                    Console.WriteLine("Nemáš dostatok peňazí na tento komponent!");
                }
            }
            else
            {
                Console.WriteLine("Žiadny pokazený komponent tohto typu nebol nájdený.");
            }

            Console.WriteLine("\nStlač Enter pre pokračovanie...");
            Console.ReadLine();
            return budget;
        }

        static Component CreateNewComponent(string choice)
        {
            return choice switch
            {
                "1" => new CPU(),
                "2" => new RAM(),
                "3" => new GPU(),
                "4" => new HDD(),
                _ => null,
            };
        }
    }
}

       








   

 
    
    

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
                Console.WriteLine("2.Ukoncit hru");
                var answer = Console.ReadLine();

                




                switch (answer)
                {
                    case "1":
                        budget = KupitKomponent(pocitac, budget);
                        break;
                    case "2":
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
                Console.WriteLine($"Komponent bol uspesne zakupeny. Zostávajuci rozpocet: {budget:C}");
            }
            else
            {
                Console.WriteLine("Nemas dostatok penazi na tento komponent!");
            }

            Console.WriteLine("\nStlac Enter pre pokracovanie...");
            Console.ReadLine();
            return budget;
        }
    }

       
}







   

 
    
    

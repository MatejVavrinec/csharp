using OpravaPocitacovProgram;
using System;
using System.Collections.Generic;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        


        decimal budget = 1200; // Počiatočný rozpočet
        bool hrabezi = true;
        Obchod obchod = new Obchod();
        List<Component> inventar = new List<Component>();
        Zakaznik momentalnyZakaznik = new Zakaznik(); // Prvý zákazník

        while (hrabezi)
        {
            Console.Clear();
            Console.WriteLine("              Vitajte v Opravarni Pocitacov.                                 ");
            Console.WriteLine("   _______________                        |*\\_/*|________");
            Console.WriteLine("  |  ___________  |     .-.     .-.      ||_/-\\_|______  |\r");
            Console.WriteLine("  | |           | |    .****. .****.     | |           | |");
            Console.WriteLine("  | |   0   0   | |    .*****.*****.     | |   0   0   | |");
            Console.WriteLine("  | |     -     | |     .*********.      | |     -     | |");
            Console.WriteLine("  | |   \\___/   | |     .*******.        | |   \\___/   | |");
            Console.WriteLine("  | |___     ___| |       .*****.        | |___________| |");
            Console.WriteLine("  |_____|\\_/|_____|       .***.          |_______________|");
            Console.WriteLine("   _|__|/ \\|_|_.............*.............._|________|_");
            Console.WriteLine("  / ********** \\                          / ********** \\");
            Console.WriteLine(" /  ************  \\                      /  ************  \\");
            Console.WriteLine("--------------------                    --------------------");

            Console.WriteLine($"Tvoj aktualny rozpocet: {budget:C}");
            Console.WriteLine("1. Zobrazit obchod");
            Console.WriteLine("2. Prezriet pocitac zakaznika");
            Console.WriteLine("3. Opravit komponenty");
            Console.WriteLine("4. Ukoncit hru");

            string volba = Console.ReadLine();
            switch (volba)
            {
                case "1":
                    budget = obchod.PrezeratObchod(budget, inventar);
                    break;
                case "2":
                    momentalnyZakaznik.UkazSpecialnyPC();
                    break;
                case "3":
                    budget = OpravitSpecialnyPC(momentalnyZakaznik, inventar, budget);
                    if (momentalnyZakaznik.Pocitac.PlneFunguje())
                    {
                        Console.WriteLine("Pocitac opraveny! Zakaznik prinasa dalsi pocitac.");
                        momentalnyZakaznik = new Zakaznik(); // Nový zákazník
                    }
                    break;
                case "4":
                    hrabezi = false;
                    break;
                default:
                    Console.WriteLine("Neplatna volba. Skus to znova.");
                    break;
            }
        }

        Console.WriteLine("Hra skoncila. Dakujeme za hranie!");
    }

    static decimal OpravitSpecialnyPC(Zakaznik zakaznik, List<Component> inventar, decimal budget)
    {
        Console.WriteLine("\nOpravovanie komponentov...");
        foreach (var component in zakaznik.Pocitac.Components)
        {
            if (!component.Funguje)
            {
                var nahrada = inventar.FirstOrDefault(c => c.GetType() == component.GetType() && c.Meno == component.Meno);
                if (nahrada!= null)
                {
                    Console.WriteLine($"Nahradzam pokazeny {component.Meno} ({component.Specifikacie})...");
                    inventar.Remove(nahrada);
                    component.Funguje = true;
                }
                else
                {
                    Console.WriteLine($"Nemas potrebny komponent {component.Meno} na opravu!");
                }
            }
        }

        if (zakaznik.Pocitac.PlneFunguje())
        {
            decimal pladba = zakaznik.Pladba;
            Console.WriteLine($"Vsetky komponenty su funkcne! Dostavas zaplatene {pladba:C}.");
            budget += pladba;
        }
        else
        {
            Console.WriteLine("Niektore komponenty stale nie su opravene!");
        }

        Console.WriteLine("\nStlac Enter pre pokracovanie...");
        Console.ReadLine();
        return budget;
    }
    
}


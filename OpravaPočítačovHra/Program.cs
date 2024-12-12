using OpravaPocitacovHra;
using static System.Formats.Asn1.AsnWriter;

namespace OpravaPočítačovHra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pocitac pocitac = new Pocitac();
            int budget = 1000;
            bool gamerunning = true;

            
            while (gamerunning)
            {
                Console.Clear();
                Console.WriteLine($"Tvoj aktualny rozpocet je " + budget + " Eur");
                pocitac.StavPC();

                Console.WriteLine("\nCo chcete urobit");
                PrintMenu();
                var answer = Console.ReadLine();

                



                
                switch (answer)
                {
                    case "1":
                       
                        


                    case "2":
                        



                    case "3":
                        

                    default:
                        {
                            Console.WriteLine("Nespravna akcia!");
                            break;
                        }

                }
            }



        
        

        }
        public static void PrintMenu()
        {
            Thread.Sleep(3000);
            
            Console.WriteLine("1.Kupit CPU");
            Console.WriteLine("2.Kupit RAM");
            Console.WriteLine("3.Kupit GPU");
            Console.WriteLine("4.Kupit HDD");

            Console.Write("Vyberte akciu:");
        }
    }
}
    
    

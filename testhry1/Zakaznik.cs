using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravaPocitacovProgram
{
    public class Zakaznik
    {
        public Pocitac Pocitac { get; private set; }
        public decimal Pladba { get; private set; }

        public Zakaznik()
        {
            NovyPocitac();
        }

        public void NovyPocitac()
        {
            Pocitac = new Pocitac();
            Pladba = new Random().Next(500, 800); // Náhodná odmena za opravu
        }

        public void UkazSpecialnyPC()
        {
            Console.WriteLine("\nPocitac zakaznika:");
            Pocitac.UkazStatus();
            Console.WriteLine("\nStlac Enter pre navrat...");
            Console.ReadLine();
        }
    }

}

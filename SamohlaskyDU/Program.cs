using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SamohlaskyDU
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadajte vetu:");
            string veta = Console.ReadLine();

            int pocetSamohlasok = SpocitajSamohlasky(veta);

            Console.WriteLine($"Pocet samohlasok vo vete: {pocetSamohlasok}");
            Console.ReadLine();
        }

        static int SpocitajSamohlasky(string veta)
        {
            int pocet = 0;
            char[] samohlasky = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'}; 

            foreach (char znak in veta.ToLower())
            {
                if (Array.Exists(samohlasky, samohlaska => samohlaska == znak))
                {
                    pocet++;
                }
            }

            return pocet;
        }
    }





}
    


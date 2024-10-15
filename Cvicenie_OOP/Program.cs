using Cvicenie_OOP;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle skodaFabia = new Vehicle();
            skodaFabia.EvidencneCisloAuta = "KM123EE";
            skodaFabia.RokVyroby = 2003;
            skodaFabia.JePlatnaSTK = true;
            skodaFabia.PriemernaSpotreba = 7.5;
            skodaFabia.TypMotoru = 'D';




            Vehicle toyotaCorolla = new Vehicle("BA999EE", 2010, false, 9.9, 'B');
            Console.WriteLine("Info o mojom aute:" + skodaFabia.VypisAuta(true));
            Console.WriteLine("Info o mojom aute:" + skodaFabia.VypisAuta(false));
            
            List<Vehicle> list = new List<Vehicle>();
            list.Add(skodaFabia);
            list.Add(toyotaCorolla);
            foreach (Vehicle vehicle in list)
            {
                Console.WriteLine(vehicle.VypisAuta(true));
            }
   
        }
    }
}
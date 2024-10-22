using System.Security.Cryptography.X509Certificates;

namespace Obdlznik
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sirka = Int32.Parse(Console.ReadLine());
            int vyska = Int32.Parse(Console.ReadLine());
            Obdlznik r = new Obdlznik(vyska,sirka);
            int obsah = r.Obsah();
            Console.WriteLine("obsah je " +obsah);
            Obdlznik re = new Obdlznik(r.vyska * 10, r.sirka * 10);
            int obsah2 = re.Obsah();
            Console.WriteLine("obsah druheho obdlznika je " + obsah2);

        }
    }
}
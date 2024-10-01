using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceniecykly
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listwords = new List<string>();

            listwords.Add("Cau");
            listwords.Add("Miso");
            listwords.Add("ake");
            listwords.Add("bolo");
            listwords.Add("vcera");
            listwords.Add("pocasie");

            int counter = 0;
            foreach (string name in listwords)


            {
                Console.WriteLine(counter++ + name);
            }
            Console.ReadLine();



        }
    }
}


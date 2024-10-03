using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aplikacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = new List<string>();
            while (true)
            {

                Console.WriteLine("\nZadajte meno:");
                string meno = Console.ReadLine();
                Console.Clear();
                if (meno == "quit")
                {
                    break;
                }
                else
                {
                    listOfNames.Add(meno);
                }
                Console.WriteLine("Vsetky mena na zozname:");
                foreach (string name in listOfNames)
                {
                    Console.WriteLine(name);
                }
            }




















        }
    }
}
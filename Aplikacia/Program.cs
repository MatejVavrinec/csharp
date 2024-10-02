using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
                string name = Console.ReadLine();
                Console.Clear();
                if (name == "quit")
                {
                    break;
                }
                else
                {
                    listOfNames.Add(name);
                }

                Console.WriteLine("Vsetky mena v zozname:");
                foreach (string item in listOfNames)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}




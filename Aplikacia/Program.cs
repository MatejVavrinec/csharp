using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Zadajte meno");
            string meno = Console.ReadLine();

            string[] names = {meno};
            foreach (string name in names)
            {
                Console.WriteLine("Zoznam mien");
            }



            

            


        }
    }
}

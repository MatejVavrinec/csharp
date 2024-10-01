using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> listwords = new List<string>();

            listwords.Add("Cau");
            listwords.Add("Miso");
            listwords.Add("ako");
            listwords.Add("bolo");
            listwords.Add("vcera");
            listwords.Add("pocasie");

            int counter = 0;
            foreach (string name in listwords)


            {
                Console.WriteLine(name + counter);
            }
        }
    }
}

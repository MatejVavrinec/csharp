using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    internal class Obcan
    {
        string meno = "Jakub";
        string meno1 = "Stevo";
        string meno2 = "Jozo";
        string meno3 = "Anabela";
        


        int vek = 20;
        int vek1 = 45;
        int vek2 = 23;
        int vek3 = 85;
        


        public string VypisInfo()
        {


            Console.WriteLine("Meno: " + meno, "Vek:" + vek);
            Console.WriteLine("Meno: " + meno1, "Vek:" + vek1);
            Console.WriteLine("Meno: " + meno2, "Vek:" + vek2);
            Console.WriteLine("Meno: " + meno3, "Vek:" + vek3);


            return VypisInfo();
        }






    }



}

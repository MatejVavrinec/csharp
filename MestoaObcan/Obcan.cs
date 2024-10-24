using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    public class Obcan
    {

        public string meno { get; set; }
        public int vek { get; set; }

        public Obcan(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Meno: {meno}, Vek: {vek}");
        }

    }





}





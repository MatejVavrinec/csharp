using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    public class Mechanik : Obcan
    {
        protected string typvozidla { get; set; }
       
        public Mechanik(string meno, int vek,string typvozidla) : base(meno, vek)
        {
            this.typvozidla = typvozidla;

        }



            public new void VypisInfo()
        {
            Console.WriteLine(meno + ", " + vek + " rokov, opravuje vozidla typu:" + typvozidla);
        }




    }
}

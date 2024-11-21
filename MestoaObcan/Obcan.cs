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
        
        protected string meno { get; set; }
        protected int vek { get; set; }
        protected StavObcana stav;

        public StavObcana Stav
        {
            get { return stav; }
            set { stav = value; }   
        }

        public Obcan(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }


        public virtual void VypisInfo()
        {
            Console.WriteLine($"Meno: {meno} {vek} Stav: {stav}");
        }
        public void VypisVek()
        {
            Console.WriteLine("vek:"+ vek);


        }

        
     

    }
    public enum StavObcana
    {
        Domaci,
        Cudzinec,
        Turista,
    }





}





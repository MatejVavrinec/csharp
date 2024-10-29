using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    internal class Lekar
    {
        public string menolekara { get; set; }
        public int veklekara { get; set; }

        public Lekar(string meno, int vek)
        {
            this.menolekara = meno;
            this.veklekara = vek;
        }
        public void VypisInfo()
        {
            Console.WriteLine($"Meno: {menolekara}, Vek: {veklekara} , lieci ludi");
        }




    }
}

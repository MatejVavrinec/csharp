﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    internal class Lekar
    {
        public string meno { get; set; }
        public int vek { get; set; }

        public Lekar(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Meno: {meno}, Vek: {vek} lieci ludi");
        }

    }





}

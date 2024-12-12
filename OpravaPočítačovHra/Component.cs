using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravaPocitacovHra
{
        public class Component
    {
        public bool Funguje { get; set; }
        public string Stav => Funguje ? "Funkcny" : "Pokazeny";


        public Component()
        {
            Random r = new Random();
            Funguje = r.Next(2) == 0; //50 percent sanca ze bude pokazeny
        }
    }
    
}

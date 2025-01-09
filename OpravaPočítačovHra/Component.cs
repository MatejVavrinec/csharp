using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravaPocitacovHra
{
        public class Component
    {
        public bool Funguje { get; set; } = true;
        public string Stav => Funguje ? "Funkcny" : "Pokazeny";


        public Component()
        {
        
        }
    }
    
}

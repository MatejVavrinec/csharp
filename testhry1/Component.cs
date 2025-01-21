using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravaPocitacovProgram
{
    public class Component
    {
        public string Meno { get; }
        public decimal Cena { get; }
        public string Specifikacie { get; }
        public bool Funguje { get; set; }
        public string Stav => Funguje ? "Funkcny" : "Pokazeny";

        public Component(string meno, decimal cena, string specifikacie)
        {
            Meno = meno;
            Cena = cena;
            Specifikacie = specifikacie;
            Funguje = false;
        }

        public Component(Component component) : this(component.Meno, component.Cena, component.Specifikacie)
        {
        }

        public override string ToString()
        {
            return $"{Meno} ({Specifikacie}) - {Cena:C}";
        }
    }
}

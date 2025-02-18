using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica_WPF
{
    internal class SpravaPouzivatelov
    {
        private static int _nextId = 1;
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Email { get; set; }
        public string Telcislo { get; set; }
        public int Idcitatela { get; set; }

        public SpravaPouzivatelov(string meno, string priezvisko, string email, string telcislo, int idcitatela)
        {
            Idcitatela = _nextId++;
            Meno = meno;
            Priezvisko = priezvisko;
            Email = email;
            Telcislo = telcislo;
            
        }
        public override string ToString()
        {
            return $"ID : {Idcitatela} : {Meno} {Priezvisko} Email : {Email} : Telefon {Telcislo}";
        }
    }
}

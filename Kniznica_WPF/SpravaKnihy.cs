using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniznica_WPF
{
    internal class SpravaKnihy
    {
        public string Meno { get; set; }

        public string Autor { get; set; }
        public int Isbn { get; set; }
        public int Rok { get; set; }
        public int Pocetkusov { get; set; }
        public string Kategoria { get; set; }

        public SpravaKnihy(string meno, string autor, int isbn, int rok, int pocetkusov, string kategoria)
        {
            Meno = meno;
            Autor = autor;
            Isbn = isbn;
            Rok = rok;
            Pocetkusov = pocetkusov;
            Kategoria = kategoria;
        }

       


    }
}


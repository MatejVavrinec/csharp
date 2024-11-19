using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihy
{
    class Kniha
    {
        private string nazov;
        private int pocetstran;


        public Kniha(string nazov, int pocetstran)
        {
            this.nazov = nazov;
            this.pocetstran = pocetstran;
        }

        public string Nazov
        {
            get { return nazov; }
            set { nazov = value; }
        }

        public int Pocetstran
        {

            get { return pocetstran; }
            set {
                if (value > 0)
                {
                    pocetstran = value;
                }
                else

                    Console.WriteLine("Chyba! Pocet stran musi bzt viac ako nula!");

                }

            }

        }
    }

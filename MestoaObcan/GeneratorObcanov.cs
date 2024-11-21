using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    public static class GeneratorObcanov
    {
        private static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik", "Monika", "Filip", "Veronika", "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };
         public static Obcan GenerujObcana()
        {
            Random r = new Random();
            int pozicia = r.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = r.Next(15, 115);
            Obcan obcan = new Obcan(meno, vek);
            int dlzkaenum = (Enum.GetValues<StavObcana>().Length);
            int nahodnyIndex = r.Next(dlzkaenum);
            obcan.Stav = (StavObcana)nahodnyIndex;

            //obcan.Stav = StavObcana.Cudzinec;

            return obcan;
        }



    }
}

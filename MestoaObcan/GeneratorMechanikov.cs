using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestoaObcan
{
    internal class GeneratorMechanikov
    {
        private static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik", "Monika", "Filip", "Veronika", "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };
        private static string[] typyvozidla = { "C#", "JavaScript", "Python", "C++", "Shell" };
        public static Mechanik GenerujMechanika()
        {
            
            Random re = new Random();
            int pozicia = re.Next(mena.Length);
            int pozicie = re.Next(typyvozidla.Length);
            string meno = mena[pozicia];
            string typvozidla = typyvozidla[pozicie];
                       

            int vek = re.Next(15, 116);

            Mechanik mechanik = new Mechanik(meno, vek, typvozidla);


            return mechanik;
        }
    }
}

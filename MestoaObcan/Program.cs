﻿using System.ComponentModel;

namespace MestoaObcan
{
    public class Program
    {
        static void Main(string[] args)
            
        {
            Mesto bratislava = Mesto.NacitajZoSuboru("mesto.json");
            
            if (bratislava == null)
            {
                bratislava =new Mesto("Bratislava");
                for (int i = 0; i < 31; i++)
                {
                    Obcan o = GeneratorObcanov.GenerujObcana();
                    bratislava.PridajObcana(o);
                }
                string subor = "mesto.json";
                bratislava.UlozDoSuboru(subor);
            }
                      
                                                        
          
            bratislava.VypisObcanov();
            bratislava.VypisMechanikov();


            






















            /*Mesto mesto1 = new Mesto("Bratislava");
            Mesto mesto2 = new Mesto("Zilina");
            Mesto2 mesto3 = new Mesto2("Nitra");
            Mesto2 mesto4 = new Mesto2("Kosice");


            Obcan obcan1 = new Obcan("Jozef", 20);        
            
             mesto1.PridajObcana(obcan1);
            mesto1.PridajObcana(new Obcan("Peter", 30));
            mesto1.PridajObcana(new Obcan("Jozo", 25));

            mesto2.PridajObcana(new Obcan("Igor", 55));
            mesto2.PridajObcana(new Obcan("Anabela", 13));
            mesto2.PridajObcana(new Obcan("Jakub", 86));


            mesto3.PridajMechanika(new Mechanik("Jakub", 46));
            mesto3.PridajLekara(new Lekar("Gabriel", 50));
            mesto4.PridajUcitela(new Ucitel("Janka", 25));

            mesto1.VypisObcanov();
            mesto2.VypisObcanov();
            mesto3.VypisObcanov();
            mesto4.VypisObcanov();*/














        }
    }
}
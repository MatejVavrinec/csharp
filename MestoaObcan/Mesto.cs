using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MestoaObcan
{
    public class Mesto
    {
        public string nazov { get; set; }
        public List <Obcan> obcania = new List<Obcan>();
        public List<Mechanik> mechanici = new List<Mechanik>();

        public Mesto(string nazov)
        {
            this.nazov = nazov;
            obcania = new List<Obcan>();
            mechanici = new List<Mechanik>();


        }
        public Mesto()
        {
            
        }

        public void PridajObcana(Obcan obcan)
        {
            obcania.Add(obcan);
        }
        public void PridajMechanika(Mechanik mechanik)
        {
            mechanici.Add(mechanik);
        }

        public void VypisMechanikov()
        {
            Console.WriteLine($"Mechanici mesta {nazov}:");
            foreach (var mechanik in mechanici)
            {
                mechanik.VypisInfo();
            }
        }

        public void VypisObcanov()
        {
            Console.WriteLine($"Obcania mesta {nazov}:");
            foreach (var obcan in obcania)
            {
                obcan.VypisInfo();
            }
        }

        public void UlozDoSuboru(string nazovSuboru)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(nazovSuboru, json);
            Console.WriteLine("Data boli ulozene");
        }
        public static Mesto NacitajZoSuboru(string nazovSuboru)
        {
            if (File.Exists(nazovSuboru))
            {
                string json = File.ReadAllText(nazovSuboru);
                Mesto mesto = JsonSerializer.Deserialize<Mesto>(json);
                return mesto;
            }
            return null;
        }
    }
}
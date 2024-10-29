namespace MestoaObcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto mesto1 = new Mesto("Bratislava");
            Mesto mesto2 = new Mesto("Zilina");


            Obcan obcan1 = new Obcan("Jozef", 20);
            mesto1.PridajObcana(obcan1);
            mesto1.PridajObcana(new Obcan("Peter", 30));
            mesto1.PridajObcana(new Obcan("Jozo", 25));

            mesto2.PridajObcana(new Obcan("Igor", 55));
            mesto2.PridajObcana(new Obcan("Anabela", 13));
            mesto2.PridajObcana(new Obcan("Jakub", 86));

            mesto1.VypisObcanov();
            mesto2.VypisObcanov();














        }
    }
}
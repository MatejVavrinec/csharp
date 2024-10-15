namespace Cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player kladnaPostava = new Player() { Name = "Arthas", AttackPower = 10, HP = 10453, Mana = 50 };
            Player zapornaPostava = new Player() { Name = "Illidian", AttackPower = 1, HP = 150600, Mana = 50 };


            
           
            
            while (true)
            {
                
                kladnaPostava.DamagePlayer(zapornaPostava);
                Console.WriteLine("Zaporna postava HP:" + zapornaPostava.HP);
                
                zapornaPostava.DamagePlayer(kladnaPostava);
                Console.WriteLine("Kladna postava HP:" + kladnaPostava.HP);

                
                
                if (kladnaPostava.HP < 0)
                {
                    Console.WriteLine("Zabil si kladnu postavu");
                    break;

                }
                if (zapornaPostava.HP < 0)
                {
                    Console.WriteLine("Zabil si zapornu postavu");
                    break;
                }
                
            }
                
              

                
            
            
        }
    }
}
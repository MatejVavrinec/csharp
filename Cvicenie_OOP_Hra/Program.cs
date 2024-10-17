using System.Runtime.CompilerServices;

namespace Cvicenie_OOP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player kladnaPostava = new Player() { Name = "Arthas", AttackPower = 10, HP = 100453, Mana = 50 };
            Player zapornaPostava = new Player() { Name = "Illidian", AttackPower = 10, HP = 100600, Mana = 50 };

            
            
           
            //attack command
            while (true)
            {
                
                kladnaPostava.DamagePlayer(zapornaPostava);
                Console.WriteLine("Zaporna postava HP:" + zapornaPostava.HP);
                
                zapornaPostava.DamagePlayer(kladnaPostava);
                Console.WriteLine("Kladna postava HP:" + kladnaPostava.HP);






                //pokus o uzdravenie postav
                if (kladnaPostava.HP <= 20)
                {
                    bool washealed = kladnaPostava.Heal();
                    if (washealed)
                    {
                        Console.WriteLine("Kladna postava bola uzdravena");
                    }
                    else
                    {
                        Console.WriteLine("Kladna postava uz nema manu a nebola ozdravena");
                    }

                }
                
                if (zapornaPostava.HP <= 20)
                {
                    bool washealed = zapornaPostava.Heal();
                    if (washealed)
                    {
                        Console.WriteLine("Zaporna postava bola uzdravena");
                    }
                    else
                    {
                        Console.WriteLine("Zaporna postava uz nema manu a nebola ozdravena");
                    }

                }

                

                    
                    Random random = new Random();
                    int randomNumber = random.Next(0,50);
                    if (randomNumber <= 1)
                    {
                        kladnaPostava.RefilMana(10);
                        Console.WriteLine("Kladnej postave sa doplnila Mana");
                    }
                                                   

                                       
                    int randomNumberdva = random.Next(0,50);
                    if (randomNumberdva <= 1)
                    {
                        zapornaPostava.RefilMana(10);
                        Console.WriteLine("Zapornej postave sa doplnila Mana");
                    }

                






                //Postava ma 0HP
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
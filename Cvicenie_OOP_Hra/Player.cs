using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OOP_Hra
{
    public class Player
    {
        
        public string Name { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public int AttackPower { get; set; }
        public int CritChance { get; set; }


        public void DamagePlayer(Player player)
        {
            int damageMultiplier = 1;


            Random random = new Random();
            int randomNumber = random.Next(0,100);
            if (randomNumber <= this.CritChance)
            {
                damageMultiplier = 2;
                Console.WriteLine(this.Name + "dal kriticky zasah!");
            }





            int HPofEnemy = player.HP;
            int AttackOfCurrentPlayer = this.AttackPower * damageMultiplier;
            int HPofEnemyAfterFight = HPofEnemy - AttackOfCurrentPlayer;
            player.HP = HPofEnemyAfterFight;

        }

        public bool Heal()
        {
            if (this.Mana > 0) 
            {
                int HPofPlayer = this.HP;
                int ManaOfPlayer = this.Mana;
                int HPOfPlayerAfterHeal = HPofPlayer + ManaOfPlayer;
                this.Mana = 0;
                this.HP = HPOfPlayerAfterHeal;
                return true;

            }
            else
            {
                return false;
            }




        }
       
        public void RefilMana(int newMana)
        {
            this.Mana += newMana;
           

            

        }


        
    }

    
}

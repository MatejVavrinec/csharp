using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace PokemoniSaBiju.Windows
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine GameEngine { get; set; }

        public List<string> PokemonFight { get; set; } = new List<string>();
        public Window_PokemonBattle(GameEngine gameEngine)
        {
            InitializeComponent();

            GameEngine = gameEngine;

            RefreshElements();

        }

        private void RefreshElements()
        {
            ProgressBar_Pokemon1_HP.Value = GameEngine.FirstPokemon.Health;
            Label_Pokemon1_HP.Content = $"{GameEngine.FirstPokemon.Health}/ {GameEngine.FirstPokemon.MaxHealth}";

            ProgressBar_Pokemon2_HP.Value = GameEngine.SecondPokemon.Health;
            Label_Pokemon2_HP.Content = $"{GameEngine.SecondPokemon.Health}/ {GameEngine.FirstPokemon.MaxHealth}";

            ListView_FightLogger.Items.Clear();

            foreach (var log in PokemonFight)
            {
                ListView_FightLogger.Items.Add(log);
            }

            if (GameEngine.FirstPokemon.Health <= 0)
            {
                Label_Pokemon2_HP.Content = "Winnner ";
                Label_Pokemon1_HP.Content = "Looooooser";

            }

            if (GameEngine.SecondPokemon.Health <= 0)
            {
                Label_Pokemon1_HP.Content = "Winnner ";
                Label_Pokemon2_HP.Content = "Looooooser";

            }
            if (GameEngine.FirstPokemon.Health <= 0 || GameEngine.SecondPokemon.Health <= 0)
            {
                Light.IsEnabled = false;
                Eather.IsEnabled = false;
                Ultimate.IsEnabled = false;
                Heal.IsEnabled = false;
            }
        }

        


        private void AIAtack()
        {
            Random rnd = new Random();
            var value = rnd.Next(0, 99);

            if (value < 10)
            {
                var damage = GameEngine.SecondPokemon.Attack1();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);

                PokemonFight.Add($"{GameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");

            }
            else if (value >= 10 && value < 30)
            {
                var damage = GameEngine.SecondPokemon.Attack2();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);

                PokemonFight.Add($"{GameEngine.SecondPokemon.Name} used Medium Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");

            }
            else if (value >= 30 && value < 80)
            {
                var damage = GameEngine.SecondPokemon.Attack3();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);

                PokemonFight.Add($"{GameEngine.SecondPokemon.Name} used Bolt Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            }
            else if (value >= 80)
            {
                var heal = GameEngine.SecondPokemon.Heal();
                GameEngine.SecondPokemon.TakeHeal(heal);
                PokemonFight.Add($"{GameEngine.SecondPokemon.Name} used heal and healt {heal}");

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            AIAtack();
            RefreshElements();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack2();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            AIAtack();
            RefreshElements();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack3();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            AIAtack();
            RefreshElements();
        }

        

        
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var heal = GameEngine.FirstPokemon.Heal();
            GameEngine.FirstPokemon.TakeHeal(heal);

            PokemonFight.Add($"{GameEngine.FirstPokemon.Name} used heal and healt {heal} ");

            AIAtack();
            RefreshElements();

        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Piskvorky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char LastPlayer { get; set; } = '⃝';
        public char PlayerOne { get; set; } = '×';
        public char PlayerTwo { get; set; } = '⃝';

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ProcessClick(Button button)
        {
            var buttonContent = button.Content.ToString();
            if (buttonContent.Contains(PlayerOne) || buttonContent.Contains(PlayerTwo))
            {
                return;
            }
            if (LastPlayer == PlayerOne)
            {
                button.Content = PlayerTwo;
                LastPlayer = PlayerTwo;
            }
            else if (LastPlayer == PlayerTwo)
            {
                button.Content = PlayerOne;
                LastPlayer = PlayerOne;
            }
            var isWinner = CheckWinner();
            if (isWinner)
            {
                MessageBox.Show("Vyhral hrac:" + LastPlayer);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick(sender as Button);
        }

        public bool CheckWinner()
        {
            var button_0x0 = Button_0x0.Content.ToString();
            var button_0x1 = Button_0x1.Content.ToString();
            var button_0x2 = Button_0x2.Content.ToString();
            var button_0x3 = Button_0x3.Content.ToString();
            var button_0x4 = Button_0x4.Content.ToString();
            var button_0x5 = Button_0x5.Content.ToString();
            var button_0x6 = Button_0x6.Content.ToString();
            var button_0x7 = Button_0x7.Content.ToString();
            var button_0x8 = Button_0x8.Content.ToString();

            //Kontrola prveho riadku dorobit ostatne
            if (button_0x0 == button_0x1 && button_0x0 == button_0x2)
            {
                return true;
            }
            return false;


        }
    }
}
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

namespace Wpf_TestAplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        
    {
    public List<string> AllUsers = new List<string>();

    public MainWindow()
        {
            InitializeComponent();
            
            Button.IsEnabled = false;

            Combobox_AccountRole.Items.Add("Automat");
            Combobox_AccountRole.Items.Add("Blackjack");

            AllUsers.Add("Automat Bonus Joker");
            AllUsers.Add("Automat Hunters dream");
            AllUsers.Add("Automat Respin Joker");
            AllUsers.Add("BlackJack Astatoro");
            AllUsers.Add("BlackJack Zucuciny");

            foreach (var user in AllUsers)
            {
                Listbox.Items.Add(user);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          var newuser = (Combobox_AccountRole.SelectedItem as string) + " " + Textbox1.Text;
            Label_FirstName.Content = newuser;
            AllUsers.Add(newuser);
            Listbox.Items.Clear();
            foreach (var user in AllUsers)
            {
                Listbox.Items.Add(user);    
            }


        }

        private void Textbox1_Label_FirstName(object sender, TextChangedEventArgs e)
        {
            


          /*  var text = Textbox1.Text;
            var inputName = Textbox1.Text;
            Label_FirstName.Content = inputName;*/  
        }

        private void CheckBox_AcceptRules_Checked(object sender, RoutedEventArgs e)
        {
            bool acceptRules = CheckBox_AcceptRules.IsChecked.Value;
            if (acceptRules)
            {
                Button.IsEnabled = true;
            }
            else
            {
                Button.IsEnabled = false;
            }
           
        }

        private void CheckBox_AcceptRules_Unchecked(object sender, RoutedEventArgs e)
        {
            Button.IsEnabled = false;
        }

        private void CheckBox_AcceptRules_Click(object sender, RoutedEventArgs e)
        {
            Button.IsEnabled = CheckBox_AcceptRules.IsChecked.Value;    

        }

       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            foreach (var user in AllUsers)
            {
                if (user.Contains("Automaty"))
                {
                    Listbox.Items.Add(user);
                } 
                else if (user.Contains("automaty"))
                {
                    Listbox.Items.Add(user);
                }
            }

        }
    }
}
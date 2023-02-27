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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oefening_Login_Secrets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    
        int aantalPogingen;
        public MainWindow()
        {
            InitializeComponent();
            aantalPogingen = 3;
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            GeheimVenster venster = new GeheimVenster(TxtUsername.Text);
            if (TxtPassword.Password == "Adm!n" && TxtUsername.Text.Length > 0) venster.Show();
            else
            {
                if (aantalPogingen == 0) this.Close();
                else MessageBox.Show($"U heeft nog {aantalPogingen} pogingen over"); aantalPogingen--;
            }
        }
    }
}

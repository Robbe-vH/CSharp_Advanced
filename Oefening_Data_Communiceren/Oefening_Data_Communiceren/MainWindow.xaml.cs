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

namespace Oefening_Data_Communiceren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NieuwVenster venster;
        public MainWindow()
        {
            InitializeComponent();
            venster = new NieuwVenster(TxtData.Text);
        }

        private void BtnGeefDoor_Click(object sender, RoutedEventArgs e)
        {

            venster.Show();
        }

        private void TxtData_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (venster != null) venster.UpdateInhoud(TxtData.Text);
        }
    }
}

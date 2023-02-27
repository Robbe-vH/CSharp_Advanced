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

namespace Les_3_Meerdere_Vensters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ExtraVenster> extraVensterList;
        public static string Secret = "Mijn donker geheim";
        public MainWindow()
        {
            InitializeComponent();
            extraVensterList = new List<ExtraVenster>();
        }

        private void BtnOpenExtraVenster_Click(object sender, RoutedEventArgs e)
        {
            ExtraVenster venster = new ExtraVenster("Mijn constructor geheim");
            extraVensterList.Add(venster);
        }

        private void BtnHideAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var venster in extraVensterList)
            {
                venster.Hide();
            }
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var venster in extraVensterList)
            {
                venster.Show();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 2. waarde mee geven met constructor
            ExtraVenster krijgtAandachtVenster = new ExtraVenster("Mijn constructor geheim");
            krijgtAandachtVenster.ShowDialog();

            // 3. data communiceren via static dataklasse
            SecretData.SecretFromData += " - en een geheim van mainwindow";
        }
    }
}

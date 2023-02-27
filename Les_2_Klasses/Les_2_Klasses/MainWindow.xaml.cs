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
using WeerClassLibrary;

namespace Les_2_Klasses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee test = new Employee();
        WeersVoorspelling voorspelling1 = new WeersVoorspelling();
        WeersVoorspelling voorspelling2 = new WeersVoorspelling();
        WeersVoorspelling mijnWeersVoorspelling = new WeersVoorspelling("Het is slecht weer vandaag", 20,30,10);
        public MainWindow()
        {
            InitializeComponent();

            test.ID = 0;
            test.FirstName = "Random";
            test.LastName = "Naam";
            test.BirthDate = new DateTime(1999, 6, 7);
            MessageBox.Show($"{mijnWeersVoorspelling.Id.ToString()}");

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TxtNaam.Text = test.BeschrijfEmployee();
            TxtInkomen.Text = test.CalculateIncome().ToString();
        }
    }
}

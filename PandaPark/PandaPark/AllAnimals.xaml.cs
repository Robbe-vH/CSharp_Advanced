using ClassLibPandaPark;
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
using System.Windows.Shapes;

namespace PandaPark
{
    /// <summary>
    /// Interaction logic for AllAnimals.xaml
    /// </summary>
    public partial class AllAnimals : Window
    {
        public AllAnimals()
        {
            InitializeComponent();
            List<Animal> animalList = MainWindow.LoadCSV();

            AnimalGrid.ItemsSource = animalList;
        }
    }
}

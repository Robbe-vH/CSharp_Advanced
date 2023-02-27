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

namespace Les_3_Meerdere_Vensters
{
    /// <summary>
    /// Interaction logic for ExtraVenster.xaml
    /// </summary>
    public partial class ExtraVenster : Window
    {
        private string gestolenGeheim;
        public ExtraVenster(string geheim)
        {
            InitializeComponent();
            // 1. public static variableen aanspreken ((Niet goed)
            gestolenGeheim = MainWindow.Secret;
            // 2. via pararmeter doorgeven is beter
            gestolenGeheim = geheim;
            // 3. DataKlasse is nog de beste
            gestolenGeheim = SecretData.SecretFromData;
        }
    }
}


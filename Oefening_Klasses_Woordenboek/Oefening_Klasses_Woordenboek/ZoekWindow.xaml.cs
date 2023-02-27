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

namespace Oefening_Klasses_Woordenboek
{
    /// <summary>
    /// Interaction logic for ZoekWindow.xaml
    /// </summary>
    public partial class ZoekWindow : Window
    {
        private Random numberGen;
        public ZoekWindow()
        {
            InitializeComponent();
            numberGen = new Random();
        }

        private string ZoekRandomWoord()
        {
            List<string> keys = Woordenboek.woordenboek.Keys.ToList();
            string key = keys[numberGen.Next(keys.Count)];
            return key;
        }

        private void BtnZoek_Click(object sender, RoutedEventArgs e)
        {
            TxtEngels.Text = ZoekRandomWoord();
        }

        private void BtnControle_Click(object sender, RoutedEventArgs e)
        {
            string engels = TxtEngels.Text;
            string nederlands = TxtNederlands.Text;

            if (Woordenboek.woordenboek.TryGetValue(engels, out string correcteVertaling))
            {
                if (correcteVertaling.Equals(nederlands))
                {
                    MessageBox.Show("Correct");
                }
                else { MessageBox.Show("Foute vertaling"); }
            }
        }
    }
}

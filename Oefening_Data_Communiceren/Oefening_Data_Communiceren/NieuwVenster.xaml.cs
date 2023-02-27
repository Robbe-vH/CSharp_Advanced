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

namespace Oefening_Data_Communiceren
{
    /// <summary>
    /// Interaction logic for NieuwVenster.xaml
    /// </summary>
    public partial class NieuwVenster : Window
    {
        public NieuwVenster(string data)
        {
            InitializeComponent();
            UpdateInhoud(data);
        }

        public void UpdateInhoud(string data)
        {
            TxtLaatDataZien.Text = data;
        }
    }
}

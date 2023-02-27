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
using System.Windows.Threading;

namespace Oefening_Login_Secrets
{
    /// <summary>
    /// Interaction logic for GeheimVenster.xaml
    /// </summary>
    public partial class GeheimVenster : Window
    {
        DispatcherTimer tijd = new DispatcherTimer();
        public GeheimVenster(string username)
        {
            InitializeComponent();
            VulListbox();
            TxtNaam.Text = username;
            tijd.Interval = new TimeSpan(0, 0, 1);
            tijd.Tick += Tijd_Tick;
            tijd.Start();
        }

        private void VulListbox()
        {
            LbxSecrets.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                ListBoxItem randomSecret = new ListBoxItem();
                randomSecret.Content = i.ToString();
                LbxSecrets.Items.Add(randomSecret);
            }
        }

        private void Tijd_Tick(object sender, EventArgs e)
        {
            TxtTijd.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

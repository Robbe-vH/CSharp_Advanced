using ClassLibPandaPark;
using System;
using System.IO;
using System.Windows;

namespace PandaPark
{
    /// <summary>
    /// Interaction logic for AddMammal.xaml
    /// </summary>
    public partial class AddMammal : Window
    {
        public AddMammal()
        {
            InitializeComponent();
        }

        private void btnAddMammal_Click(object sender, RoutedEventArgs e)
        {
            Mammal newMammal = new Mammal(TxtName.Text, Txttype.Text, (ChkIsDangerous.IsChecked == true), CmbxDiet.SelectedItem.ToString(), CmbxGender.SelectedItem.ToString(), (System.DateTime)DateDayOfBirth.SelectedDate, TxtCountry.Text);

            using (StreamWriter sw = new StreamWriter(Settings.AnimalCSV))
            {
                sw.WriteLine(newMammal);

                ClearAllFields();
            }
        
        }

        private void ClearAllFields()
        {
            TxtName.Clear();
            Txttype.Clear();
            ChkIsDangerous.IsChecked = false;
            CmbxDiet.SelectedIndex = -1;
            CmbxGender.SelectedIndex = -1;
            TxtCountry.Clear();
        }
    }
}

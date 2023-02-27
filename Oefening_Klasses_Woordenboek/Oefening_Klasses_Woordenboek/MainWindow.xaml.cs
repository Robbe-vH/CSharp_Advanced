using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Oefening_Klasses_Woordenboek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            HerlaadDictionary(Woordenboek.woordenboek);
        }

        private void HerlaadDictionary(Dictionary<string, string> woordenboek)
        {
            LbxWoorden.Items.Clear();
            foreach (string key in Woordenboek.woordenboek.Keys)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = $"{key} - {Woordenboek.woordenboek[key]}";
                LbxWoorden.Items.Add(item);
            }
        }



        private void MnItZoeken_Click(object sender, RoutedEventArgs e)
        {
            ZoekWindow zoekVenster = new ZoekWindow();
            zoekVenster.ShowDialog();
        }

        private void MnItClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MnItInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            // engelse term en nederlandse term in dictionary steken
            Woordenboek.woordenboek.Add(TxtEngelseTerm.Text, TxtNederlandseTerm.Text);
            HerlaadDictionary(Woordenboek.woordenboek);

        }

        private void BtnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            if (LbxWoorden.SelectedItem != null)
            {
                LbxWoorden.Items.Remove(LbxWoorden.SelectedItem);

                ListBoxItem selected = (ListBoxItem)LbxWoorden.SelectedItem;

                string[] keyEnValue = selected.Content.ToString().Split('-');
                string key = keyEnValue[0].Replace("", "");

                Woordenboek.woordenboek.Remove(key);
                LbxWoorden.Items.Remove(LbxWoorden.SelectedItem);
            }
            
    }
}

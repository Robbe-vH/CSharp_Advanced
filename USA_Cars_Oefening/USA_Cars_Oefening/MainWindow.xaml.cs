using ClassLibUSACars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace USA_Cars_Oefening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MnItReadFile_Click(object sender, RoutedEventArgs e)
        {
            TxtCSV.Clear();
            TxtCSV.Text += CarData.GetCars();
        }

        private void MnItConvertToCars_Click(object sender, RoutedEventArgs e)
        {
            DgdCars.ItemsSource = CarData.GetCarsFromFile();
        }

        private void MnItSummaryCars_Click(object sender, RoutedEventArgs e)
        {
            foreach (KeyValuePair<string, List<Car>> brand in CarData.GroupCarsByName())
            {
                double avgPrice = 0;
                double totalPrice = 0;
                foreach (Car car in brand.Value)
                {
                    totalPrice += car.Price;
                }
                avgPrice = totalPrice / brand.Value.Count;

                TxtSummary.Text += $"{brand.Key.PadRight(30)} {brand.Value.Count.ToString().PadRight(2)} cars - " +
                    $"avg Price: ${String.Format("{0:0.00}", avgPrice)} \n";
            }
        }
    }
}
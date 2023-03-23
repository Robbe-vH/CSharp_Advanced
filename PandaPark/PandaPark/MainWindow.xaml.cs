using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using ClassLibPandaPark;

namespace PandaPark
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

        public static List<Animal> LoadCSV()
        {
            using (StreamReader sr = new StreamReader(Settings.AnimalCSV))
            {
                List<Animal> allAnimals = new List<Animal>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line[0] == 'B')
                    {
                        Bird newAnimal = new Bird(line.Split(';')[1], line.Split(';')[2], Convert.ToBoolean(line.Split(';')[3]), line.Split(';')[4], line.Split(';')[5], Convert.ToDateTime(line.Split(';')[6]), line.Split(';')[7], line.Split(';')[8], Convert.ToInt32(line.Split(';')[9]));
                        allAnimals.Add(newAnimal);
                    }
                    else if (line[0] == 'M')
                    {
                        Mammal newAnimal = new Mammal(line.Split(';')[1], line.Split(';')[2], Convert.ToBoolean(line.Split(';')[3]), line.Split(';')[4], line.Split(';')[5], Convert.ToDateTime(line.Split(';')[6]), line.Split(';')[7]);
                        allAnimals.Add(newAnimal);
                    }
                }

                return allAnimals;
            }
        }

        private void BtnAllAnimals_Click(object sender, RoutedEventArgs e)
        {            
            List<Animal> animalList = LoadCSV();
            Window allAnimalsWindow = new AllAnimals();
            allAnimalsWindow.ShowDialog();

        }

        private void BtnAddMammal_Click(object sender, RoutedEventArgs e)
        {
            Window addMammalWindow = new AddMammal();
            addMammalWindow.ShowDialog();
        }

        private void BtnAddBird_Click(object sender, RoutedEventArgs e)
        {
            Window addBirdWindow = new AddBird();
            addBirdWindow.ShowDialog();
        }

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            Window helpWindow = new Help();
            helpWindow.Show();
        }

        private void BtnSearchanimal_Click(object sender, RoutedEventArgs e)
        {
            string search = TxtSearchAnimal.Text;
            // search animals by name, return first animal
        }
    }
}

using System;
using System.IO;
using System.Text;
using System.Windows;

namespace Directories_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string padNaarMyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string naamVanbestand = "BestandWaarinIkShitOpsla.txt";
            string volledigePad = Path.Combine(padNaarMyDocuments, naamVanbestand);

            //File.Create(volledigePad);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"My Documents: {padNaarMyDocuments}");

            sb.AppendLine("Bestanden:");
            string[] bestanden = Directory.GetFiles(padNaarMyDocuments);
            foreach (string bestand in bestanden)
            {
                sb.AppendLine(bestand);
            }

            sb.AppendLine("Mappen:");
            string[] folders = Directory.GetDirectories(padNaarMyDocuments);
            foreach (string folder in folders)
            {
                sb.AppendLine(folder);
            }
            TxtOutput.Text = sb.ToString();
        }
    }
}
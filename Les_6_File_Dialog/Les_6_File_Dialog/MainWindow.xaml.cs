using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace Les_6_File_Dialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FILE_NAME = "bestand.txt";
        public MainWindow()
        {
            InitializeComponent();

            File.WriteAllText(FILE_NAME, "BlablablablablaZ\n random tekst enzo\n sldkfdsjf");

            OpenFileDialog ofd = new OpenFileDialog() { InitialDirectory = Environment.CurrentDirectory };

            if (ofd.ShowDialog() == true)
            {
                string filepath = ofd.FileName;
                using (StreamReader sr = new StreamReader(filepath))
                {
                    LblTextVanBestand.Text += sr.ReadToEnd();
                }
            }
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { InitialDirectory = Environment.CurrentDirectory};

            if (sfd.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(Txtinput.Text);
                }

            }
        }

        private void BtnCrash_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("UwMoeder.txt"))
                {
                    sr.ReadLine();
                }
            }
            catch (FileNotFoundException ex)
            {

                MessageBox.Show("Fout bestand hoer", "Alarm " + ex.Message, MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }
    }
}

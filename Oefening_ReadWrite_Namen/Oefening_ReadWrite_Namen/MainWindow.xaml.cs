using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Oefening_ReadWrite_Namen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string fileName = "personen.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, RoutedEventArgs e)
        {
            TxtFirstName.Clear();
            TxtLastName.Clear();
            LbxUsers.Items.Clear();
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    do
                    {
                        string line = sr.ReadLine();
                        string firstName = line.Split(',')[0];
                        string lastName = line.Split(',')[1];
                        TxtFirstName.Text += firstName + "\n";
                        TxtLastName.Text += lastName + "\n";

                        User user = new User();
                        user.FirstName = firstName;
                        user.LastName = lastName;

                        ListBoxItem userItem = new ListBoxItem();
                        userItem.Content = user.ToString();
                        LbxUsers.Items.Add(user);
                    } while (!sr.EndOfStream);
                }
            }
            else
            {
                File.Create(fileName);
            }
        }

        private void BtnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            string allFirstNames = TxtFirstName.Text;
            string allLastNames = TxtLastName.Text;
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                for (int i = 0; i < allFirstNames.Split('\n').Length; i++)
                {
                    string csvLine = $"{allFirstNames.Split('\n')[i]},{allLastNames.Split('\n')[i]}";
                    sw.WriteLine(csvLine);
                }
            }
        }

        private void BtnAddToFile_Click(object sender, RoutedEventArgs e)
        {
            TxtFirstName.Text += TxtFirstNameInput.Text + "\n";
            TxtLastName.Text += TxtLastNameInput.Text + "\n";

            TxtFirstNameInput.Clear();
            TxtLastNameInput.Clear();
        }

        private void TxtLastNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeOutput();
        }

        private void TxtFirstNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeOutput();
        }

        private void ChangeOutput()
        {
            TxtOutput.Text = $"{TxtFirstNameInput.Text},{TxtLastNameInput.Text}";
        }
    }
}
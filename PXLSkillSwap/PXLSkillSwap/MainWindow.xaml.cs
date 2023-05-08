using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using SkillSwapClassLibrary;

namespace PXLSkillSwap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable dtWorkShops;
        DataTable dtCategories;

        public MainWindow()
        {
            InitializeComponent();
            dtWorkShops = SkillSwapData.GetSkillSwapDataSet().Tables["Workshops"];
            dtCategories = SkillSwapData.GetSkillSwapDataSet().Tables["Categories"];
        }

        private void BtnShowWorkshops_Click(object sender, RoutedEventArgs e)
        {
            DgdSkillSwap.ItemsSource = dtWorkShops.DefaultView;
        }

        private void BtnShowCategories_Click(object sender, RoutedEventArgs e)
        {
            DgdSkillSwap.ItemsSource = dtCategories.DefaultView;

        }

        private void BtnShowMusic_Click(object sender, RoutedEventArgs e)
        {
            var query = dtWorkShops.AsEnumerable().Where(
                w => w["CategoryID"].Equals("2"));

            DgdSkillSwap.ItemsSource = query.AsDataView();
        }

        private void BtnShowPast14_Click(object sender, RoutedEventArgs e)
        {
            DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 0, 0);
            var query = dtWorkShops.AsEnumerable().Where(
                               w => DateTime.Compare(w["Time"], startTime)).Select(
                               w => new { Name = w["WorkshopName"] });
            DgdSkillSwap.ItemsSource = query;
        }

        private void BtnShowBuildingA_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnShowDrones_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnShowListOfWorkshopNames_Click(object sender, RoutedEventArgs e)
        {
            var query = dtWorkShops.AsEnumerable().Select(w => new { Name = w["WorkshopName"] });
            DgdSkillSwap.ItemsSource = query;
        }

        private void BtnShowListOfWorkshopNamesAndCategoryNames_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
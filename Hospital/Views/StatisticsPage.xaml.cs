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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hospital.ViewModels;

namespace Hospital.Views
{
    /// <summary>
    /// Interaction logic for StatisticGraphPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        public StatisticsViewModel BaseStatisticsViewModel { get; set; } 
        public StatisticsPage()
        {
            InitializeComponent();
            BaseStatisticsViewModel = new StatisticsViewModel();
            DataContext = BaseStatisticsViewModel;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (ListViewPageControl.Items.Count > 0)
            {
                BaseStatisticsViewModel.SwitchStatisticsCommand.Execute(ListViewPageControl.Items[0]);
                ((ListViewItem)ListViewPageControl.Items[0]).IsSelected = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hospital.ViewModels.StatisticsVIewModels;

namespace Hospital.Views.StatisticsPages
{
    public class BaseStatisticsPage : Page
    {
        public BaseStatisticsViewModel BaseStatisticsViewModel { get; set; }
        public double PENIS { get; set; }
        public BaseStatisticsPage()
        {
            Loaded += BaseStatisticsPage_Loaded;
        }

        private void BaseStatisticsPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Task.Run(() => BaseStatisticsViewModel.CalculateStatistics());
        }
    }
}

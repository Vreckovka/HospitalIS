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
using HospitalIS.Core.ViewModels.StatisticsVIewModels;


namespace HospitalIS.Views.StatisticsPages
{
    /// <summary>
    /// Interaction logic for AvrageHeightStatistics.xaml
    /// </summary>
    public partial class HeavierPeopleStatisticsPage
    {
        public HeavierPeopleStatisticsPage()
        {
            InitializeComponent();
            DataContext = new AvrageHeightStatisticsViewModel();
        }
    }
}

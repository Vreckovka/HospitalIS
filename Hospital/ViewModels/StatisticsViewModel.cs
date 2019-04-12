using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hospital.ViewModels.Commands;
using Hospital.ViewModels.StatisticsVIewModels;
using Hospital.Views;
using Hospital.Views.StatisticsPages;

namespace Hospital.ViewModels
{
    public class StatisticsViewModel : BaseViewModel
    {
        public Page DisplayedPage { get; set; }
        public Dictionary<string, Page> Pages { get; set; } = new Dictionary<string, Page>();
        public SwitchStatisticsCommand SwitchStatisticsCommand { get; set; }

        public StatisticsViewModel()
        {
            SwitchStatisticsCommand = new SwitchStatisticsCommand(this);

            Pages.Add("Heavier people\nthen avrage", new AvrageHeightStatisticsPage());
        }  
    }
}

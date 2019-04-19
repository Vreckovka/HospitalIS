using System.Windows.Input;
using HospitalIS.Core.Models;
using HospitalIS.Core.ViewModels.Commands;
using HospitalIS.ViewModels;
using HospitalIS.ViewModels.Commands;

namespace HospitalIS.Core.ViewModels
{
    public class StatisticsViewModel : BaseViewModel
    {
        public StatisticsPages DisplayedPage { get; set; } = StatisticsPages.HeavierPeople;
        public ICommand SwichStatisticsCommand { get; set; }

        public StatisticsViewModel()
        {
            SwichStatisticsCommand = new SwitchStatisticsCommand(this);
        }
    }
}

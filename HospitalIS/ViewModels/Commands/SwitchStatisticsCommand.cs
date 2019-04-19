using System;
using HospitalIS.Core.Models;
using HospitalIS.Core.ViewModels;
using HospitalIS.UserControls;

namespace HospitalIS.ViewModels.Commands
{
    public class SwitchStatisticsCommand : CommandWithViewModel
    {
        public SwitchStatisticsCommand(BaseViewModel baseViewModel) : base(baseViewModel)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            if (parameter != null)
            {
                switch ((StatisticsPages)parameter)
                {
                    case StatisticsPages.HeavierPeople:
                        ((StatisticsViewModel) BaseViewModel).DisplayedPage = StatisticsPages.HeavierPeople;
                        break;
                }
            }
        }


        public override event EventHandler CanExecuteChanged;
    }
}

using System;
using HospitalIS.ViewModels;
using HospitalIS.ViewModels.Commands;

namespace HospitalIS.Core.ViewModels.Commands
{
    public class SwitchStatisticsCommandWithViewModel : CommandWithViewModel
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            //Page selectedPage = null;

            //if (parameter is ListViewItem)
            //{
            //    ((StatisticsViewModel)BaseViewModel).Pages.TryGetValue(((ListViewItem)parameter).Content.ToString(), out selectedPage);
            //    ((StatisticsViewModel)BaseViewModel).DisplayedPage = selectedPage;
            //}

        }

        public override event EventHandler CanExecuteChanged;

        public SwitchStatisticsCommandWithViewModel(BaseViewModel baseViewModel) : base(baseViewModel)
        {
        }
    }
}

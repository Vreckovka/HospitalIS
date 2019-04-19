using System;
using HospitalIS.ViewModels.Commands;

namespace HospitalIS.Core.ViewModels.Commands
{
    class StatisticsLoadedCommandWithViewModel : CommandWithViewModel
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            
        }

        public override event EventHandler CanExecuteChanged;

        public StatisticsLoadedCommandWithViewModel(BaseViewModel baseViewModel) : base(baseViewModel)
        {
        }
    }
}

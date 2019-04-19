using System;
using HospitalIS.ViewModels.Commands;

namespace HospitalIS.Core.ViewModels.Commands
{
   public class SwitchGraphCommandWithViewModel : CommandWithViewModel
    {

        public SwitchGraphCommandWithViewModel(BaseViewModel baseViewModel) : base(baseViewModel)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            //BaseGraphViewModel selectedViewModel = null;

            //if (parameter is ListViewItem)
            //{
            //    ((GraphsViewModel)BaseViewModel).Graphs.TryGetValue(((ListViewItem)parameter).Content.ToString(), out selectedViewModel);

            //    ((GraphsViewModel)BaseViewModel).ActualGraphViewModel = selectedViewModel;

            //    //If data had changed
            //    selectedViewModel?.GetValues();
            //    ((GraphsViewModel) BaseViewModel).Chart.Update(true, true);
            //}

        }

        public override event EventHandler CanExecuteChanged;
    }
}

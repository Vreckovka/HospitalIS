using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using HospitalIS.ViewModels.GraphsViewModels;

namespace HospitalIS.ViewModels.Commands
{
   public class SwitchGraphCommand : BaseCommand
    {

        public SwitchGraphCommand(BaseViewModel baseViewModel) : base(baseViewModel)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            BaseGraphViewModel selectedViewModel = null;

            if (parameter is ListViewItem)
            {
                ((GraphsViewModel)BaseViewModel).Graphs.TryGetValue(((ListViewItem)parameter).Content.ToString(), out selectedViewModel);

                ((GraphsViewModel)BaseViewModel).ActualGraphViewModel = selectedViewModel;

                //If data had changed
                selectedViewModel?.GetValues();
                ((GraphsViewModel) BaseViewModel).Chart.Update(true, true);
            }

        }

        public override event EventHandler CanExecuteChanged;
    }
}

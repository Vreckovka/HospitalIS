using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HospitalIS.ViewModels.Commands
{
    public class SwitchStatisticsCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            Page selectedPage = null;

            if (parameter is ListViewItem)
            {
                ((StatisticsViewModel)BaseViewModel).Pages.TryGetValue(((ListViewItem)parameter).Content.ToString(), out selectedPage);
                ((StatisticsViewModel)BaseViewModel).DisplayedPage = selectedPage;
            }

        }

        public override event EventHandler CanExecuteChanged;

        public SwitchStatisticsCommand(BaseViewModel baseViewModel) : base(baseViewModel)
        {
        }
    }
}

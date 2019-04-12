using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hospital.ViewModels.Commands
{
    class StatisticsLoadedCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            
        }

        public override event EventHandler CanExecuteChanged;

        public StatisticsLoadedCommand(BaseViewModel baseViewModel) : base(baseViewModel)
        {
        }
    }
}

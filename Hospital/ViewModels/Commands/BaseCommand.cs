using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hospital.ViewModels.Commands
{
    public abstract class BaseCommand : ICommand
    {
        protected BaseViewModel BaseViewModel { get; set; }

        public BaseCommand(BaseViewModel baseViewModel)
        {
            BaseViewModel = baseViewModel;
        }

        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);

        public abstract event EventHandler CanExecuteChanged;
    }
}

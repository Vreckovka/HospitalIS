using System;
using System.Windows.Input;

namespace HospitalIS.Core.ViewModels.Commands
{
    public class RelayParametlessCommand : ICommand
    {
        Action _action;
        public RelayParametlessCommand(Action action)
        {
            _action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged;
    }
}

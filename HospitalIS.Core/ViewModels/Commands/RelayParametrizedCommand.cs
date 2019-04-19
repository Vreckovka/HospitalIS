using System;
using System.Windows.Input;

namespace HospitalIS.Core.ViewModels.Commands
{
   public class RelayParametrizedCommand : ICommand
    {
        Action<object> _action;

        public RelayParametrizedCommand(Action<object> action)
        {
            _action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}

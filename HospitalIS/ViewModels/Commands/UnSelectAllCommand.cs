using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using HospitalIS.UserControls;

namespace HospitalIS.ViewModels.Commands
{
    public class UnSelectAllCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var menuItems = ((ListView)parameter);

            foreach (MenuItemWithIcon menuItem in menuItems.Items)
            {
                menuItem.IsSelected = false;
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}

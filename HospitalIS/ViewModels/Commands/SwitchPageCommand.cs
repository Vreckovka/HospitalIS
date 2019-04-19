using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using HospitalIS.Models;
using HospitalIS.UserControls;


namespace HospitalIS.ViewModels.Commands
{
    public class SwitchPageCommand : BaseCommand
    {
        public SwitchPageCommand(BaseViewModel baseViewModel) : base(baseViewModel)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            switch ((ApplicationPage)((MenuItemWithIcon)parameter).MenuEnum)
            {
                case ApplicationPage.Pacients:
                    ((MainWindowViewModel) BaseViewModel).DisplayedPage = ApplicationPage.Pacients;
                    break;
                case ApplicationPage.Graphs:
                    ((MainWindowViewModel)BaseViewModel).DisplayedPage = ApplicationPage.Graphs;
                    break;
                case ApplicationPage.Statistics:
                    ((MainWindowViewModel)BaseViewModel).DisplayedPage = ApplicationPage.Statistics;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(parameter), parameter, null);
            }

        }

        public override event EventHandler CanExecuteChanged;
    }
}

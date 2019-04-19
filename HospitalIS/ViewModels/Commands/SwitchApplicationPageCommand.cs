using System;
using HospitalIS.Core.Models;
using HospitalIS.Core.ViewModels;
using HospitalIS.UserControls;

namespace HospitalIS.ViewModels.Commands
{
    public class SwitchApplicationPageCommand : CommandWithViewModel
    {
        public SwitchApplicationPageCommand(BaseViewModel baseViewModel) : base(baseViewModel)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            if (parameter != null)
            {
                switch ((ApplicationPages) ((MenuItemWithIcon) parameter).MenuEnum)
                {
                    case ApplicationPages.Pacients:
                        ((MainWindowViewModel) BaseViewModel).DisplayedPage = ApplicationPages.Pacients;
                        break;
                    case ApplicationPages.Graphs:
                        ((MainWindowViewModel) BaseViewModel).DisplayedPage = ApplicationPages.Graphs;
                        break;
                    case ApplicationPages.Statistics:
                        ((MainWindowViewModel) BaseViewModel).DisplayedPage = ApplicationPages.Statistics;
                        break;
                }
            }
        }


        public override event EventHandler CanExecuteChanged;
    }
}

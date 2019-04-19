using System;
using HospitalIS.Core.Models;
using HospitalIS.Core.ViewModels;
using HospitalIS.UserControls;

namespace HospitalIS.ViewModels.Commands
{
    public class SwitchGraphCommand : CommandWithViewModel
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
            if (parameter != null)
            {
                switch ((GraphPages)parameter)
                {
                    case GraphPages.Age:
                        ((GraphsViewModel) BaseViewModel).DisplayedPage = GraphPages.Age;
                        break;
                    case GraphPages.Height:
                        ((GraphsViewModel) BaseViewModel).DisplayedPage = GraphPages.Height;
                        break;
                    case GraphPages.Weight:
                        ((GraphsViewModel) BaseViewModel).DisplayedPage = GraphPages.Weight;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(parameter), parameter, null);
                }
            }
        }


        public override event EventHandler CanExecuteChanged;
    }
}

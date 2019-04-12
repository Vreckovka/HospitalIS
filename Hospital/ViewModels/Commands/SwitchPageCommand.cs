using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace Hospital.ViewModels.Commands
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
            Page selectedPage = null;

            if (parameter is ListViewItem)
            {
                ((MainWindowViewModel)BaseViewModel).Pages.TryGetValue(((ListViewItem)parameter).Content.ToString(), out selectedPage);
                ((MainWindowViewModel)BaseViewModel).DisplayedPage = selectedPage;
            }

        }

        public override event EventHandler CanExecuteChanged;
    }
}

using System.Windows.Input;
using HospitalIS.Core.Models;
using HospitalIS.Core.ViewModels;
using HospitalIS.Core.ViewModels.Commands;
using HospitalIS.ViewModels.Commands;

namespace HospitalIS.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ApplicationPages DisplayedPage { get; set; } = ApplicationPages.Pacients;
        public ICommand SwitchPageCommand { get; set; } 
        public MainWindowViewModel()
        {
            SwitchPageCommand = new SwitchApplicationPageCommand(this);
        }
    }
}

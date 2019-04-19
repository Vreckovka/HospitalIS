using System.Windows.Input;
using HospitalIS.Core.Models;
using HospitalIS.Core.ViewModels;
using HospitalIS.Core.ViewModels.Commands;
using HospitalIS.ViewModels.Commands;

namespace HospitalIS.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ApplicationPage DisplayedPage { get; set; } = ApplicationPage.Pacients;
        public ICommand SwitchPageCommand { get; set; } 
        public ICommand UnSelectAllCommand { get; set; }
        public MainWindowViewModel()
        {
            SwitchPageCommand = new SwitchPageCommandWithViewModel(this);
            UnSelectAllCommand = new UnSelectAllCommand();
        }
    }
}

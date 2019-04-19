using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HospitalIS.Models;
using HospitalIS.ViewModels.Commands;
using HospitalIS.Views;

namespace HospitalIS.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ApplicationPage DisplayedPage { get; set; } = ApplicationPage.Pacients;
        public ICommand SwitchPageCommand { get; set; }
        public MainWindowViewModel()
        {
            SwitchPageCommand = new SwitchPageCommand(this);
            //Pages.Add("Pacients", new PacientsPage());
            //Pages.Add("Graphs", new GraphsPage());
            //Pages.Add("Statistics", new StatisticsPage());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HospitalIS.Core.Models;
using HospitalIS.Core.ViewModels;
using HospitalIS.Core.ViewModels.Commands;
using HospitalIS.ViewModels.Commands;


namespace HospitalIS.ViewModels
{
    public class GraphsViewModel : BaseViewModel
    {
        public GraphPages DisplayedPage { get; set; } = GraphPages.Age;
        public ICommand SwitchGraphCommand { get; set; }

        public GraphsViewModel()
        {
            SwitchGraphCommand = new SwitchGraphCommand(this);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using HospitalIS.Core.DataContexts;
using HospitalIS.Core.Models;
using HospitalIS.Core.ViewModels.Commands;
using HospitalIS.DataContexts;
using HospitalIS.ViewModels;
using HospitalIS.ViewModels.Commands;

namespace HospitalIS.Core.ViewModels
{

    public class PacientViewModel : BaseViewModel
    {
        public Pacients Pacients { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand GetSiblingsCommand { get; set; }
        public List<Pacient> ActualPacientSiblings { get; set; }


        private DataContext _dataContext;
        public PacientViewModel(DataContext dataContext)
        {
            _dataContext = dataContext;

            GetSiblingsCommand = new GetSiblingsCommand(this);
            SaveCommand = new RelayParametlessCommand(() => Task.Run(() => _dataContext.Save()));

            Pacients = _dataContext.Pacients;
        }
    }
}

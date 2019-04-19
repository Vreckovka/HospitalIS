using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
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
        public GetSiblingsCommandWithViewModel GetSiblingsCommandWithViewModel { get; set; }
        public ICommand SaveToXMLCommand { get; set; }
        public List<Pacient> ActualPacientSiblings { get; set; }


        private IDataContext _dataContext;
        public PacientViewModel(IDataContext dataContext)
        {
            GetSiblingsCommandWithViewModel = new GetSiblingsCommandWithViewModel(this);

            SaveToXMLCommand = new RelayParametlessCommand(() => Task.Run(() => _dataContext.Save()));
            Pacients = XmlContext.Pacients;
        }

       
    }
}

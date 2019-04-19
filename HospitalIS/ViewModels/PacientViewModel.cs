using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using Hospital.DataContexts;
using Hospital.ViewModels.Commands;
using HospitalIS.Models;
using HospitalIS.ViewModels.Commands;


namespace HospitalIS.ViewModels
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

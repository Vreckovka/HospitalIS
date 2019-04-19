using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Hospital.DataContexts;
using HospitalIS.Models;

namespace HospitalIS.ViewModels.Commands
{
    public class SaveToXMLCommand : BaseCommand
    {

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            Task.Run(() => XmlContext.SerializePacients());
        }

        public override event EventHandler CanExecuteChanged;

        public SaveToXMLCommand(BaseViewModel baseViewModel) : base(baseViewModel)
        {
        }
    }
}

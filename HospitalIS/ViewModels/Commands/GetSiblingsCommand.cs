using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HospitalIS.Models;
using HospitalIS.Other;

namespace HospitalIS.ViewModels.Commands
{
    public class GetSiblingsCommandWithViewModel : CommandWithViewModel
    {
        public GetSiblingsCommandWithViewModel(BaseViewModel baseViewModel) : base(baseViewModel)
        {
            BaseViewModel = baseViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            if (((object[])parameter)[0] is Pacient)
            {
                Pacient pacient = (Pacient)(((object[])parameter)[0]);
                string[] postfixes = (string[])((object[])parameter)[1];

                var lastName = pacient.LastName.RemovePostfixes(postfixes);

                var model = ((PacientViewModel)BaseViewModel);
                model.ActualPacientSiblings = (from x in model.Pacients
                                               where x.LastName.RemovePostfixes(postfixes).GetLvenshteinDistance(lastName) <= 1
                                               where x.PID != pacient.PID
                                               select x).ToList();
            }
        }

        public override event EventHandler CanExecuteChanged;
    }
}

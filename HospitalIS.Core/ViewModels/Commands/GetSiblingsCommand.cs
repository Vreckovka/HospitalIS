using System;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using HospitalIS.Core.DataContexts;
using HospitalIS.Core.Models;
using HospitalIS.Core.Other;
using HospitalIS.ViewModels.Commands;

namespace HospitalIS.Core.ViewModels.Commands
{
    public class GetSiblingsCommand : CommandWithViewModel
    {
        public GetSiblingsCommand(BaseViewModel baseViewModel) : base(baseViewModel)
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
                Task.Run(() =>
                {
                    Pacient pacient = (Pacient) (((object[]) parameter)[0]);
                    string[] postfixes = (string[]) ((object[]) parameter)[1];

                    var lastName = pacient.LastName.RemovePostfixes(postfixes);

                    var pacients = IoC.IoC.Container.Resolve<DataContext>().Pacients;

                    ((PacientViewModel) BaseViewModel).ActualPacientSiblings =
                        (from x in pacients
                            where x.LastName.RemovePostfixes(postfixes).GetLvenshteinDistance(lastName) <= 1
                            where x.PID != pacient.PID
                            select x).ToList();
                });
            }
        }

        public override event EventHandler CanExecuteChanged;
    }
}

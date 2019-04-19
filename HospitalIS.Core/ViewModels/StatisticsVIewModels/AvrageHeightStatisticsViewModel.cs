using System.Collections.Generic;
using System.Linq;
using Autofac;
using HospitalIS.Core.DataContexts;
using HospitalIS.Core.Models;

namespace HospitalIS.Core.ViewModels.StatisticsVIewModels
{
    public class AvrageHeightStatisticsViewModel : BaseViewModel
    {
        public List<Pacient> Pacients { get; set; } = new List<Pacient>();
        public double AvrageWeight { get; set; }
        public double AvrageHeight { get; set; }

        public AvrageHeightStatisticsViewModel()
        {
            CalculateStatistics();
        }

        public void CalculateStatistics()
        {
            var pacients = IoC.IoC.Container.Resolve<DataContext>().Pacients;

            if (pacients.Count != 0)
            {
                AvrageWeight = (from y in pacients select y).Average(y => y.Weight);
                Pacients = (from x in pacients where x.Weight > AvrageWeight select x).ToList();
                AvrageHeight = (from y in Pacients select y).Average(y => y.Height);
            }
        }
    }
}

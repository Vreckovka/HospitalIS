using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using HospitalIS.Core.DataContexts;
using HospitalIS.Core.IoC;
using HospitalIS.Core.Models;
using HospitalIS.DataContexts;

namespace HospitalIS.ViewModels.StatisticsVIewModels
{
    public class AvrageHeightStatisticsViewModel : BaseStatisticsViewModel
    {
        public List<Pacient> Pacients { get; set; } = new List<Pacient>();
        public double AvrageWeight { get; set; }
        public double AvrageHeight { get; set; }
        public override void CalculateStatistics()
        {
            var pacients = IoC.Container.Resolve<DataContext>().Pacients;

            if (pacients.Count != 0)
            {
                AvrageWeight = (from y in pacients select y).Average(y => y.Weight);
                Pacients = (from x in pacients where x.Weight > AvrageWeight select x).ToList();
                AvrageHeight = (from y in Pacients select y).Average(y => y.Height);
            }
        }
    }
}

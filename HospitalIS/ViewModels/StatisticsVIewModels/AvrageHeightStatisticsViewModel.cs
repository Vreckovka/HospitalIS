using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DataContexts;
using HospitalIS.Models;

namespace HospitalIS.ViewModels.StatisticsVIewModels
{
    public class AvrageHeightStatisticsViewModel : BaseStatisticsViewModel
    {
        public List<Pacient> Pacients { get; set; } = new List<Pacient>();
        public double AvrageWeight { get; set; }
        public double AvrageHeight { get; set; }
        public override void CalculateStatistics()
        {
            if (XmlContext.Pacients.Count != 0)
            {
                AvrageWeight = (from y in XmlContext.Pacients select y).Average(y => y.Weight);
                Pacients = (from x in XmlContext.Pacients where x.Weight > AvrageWeight select x).ToList();
                AvrageHeight = (from y in Pacients select y).Average(y => y.Height);
            }
        }
    }
}

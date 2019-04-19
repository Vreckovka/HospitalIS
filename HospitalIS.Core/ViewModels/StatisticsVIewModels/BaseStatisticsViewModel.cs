using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalIS.Core.ViewModels;

namespace HospitalIS.ViewModels.StatisticsVIewModels
{
    public abstract class BaseStatisticsViewModel : BaseViewModel
    {
        public abstract void CalculateStatistics();
    }
}

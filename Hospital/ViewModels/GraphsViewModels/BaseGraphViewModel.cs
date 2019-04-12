using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.ViewModels.Commands;
using LiveCharts;

namespace Hospital.ViewModels.GraphsViewModels
{
   public abstract class BaseGraphViewModel : BaseViewModel
    {
        protected const int labelCount = 6;
        public ChartValues<double> ColumnValues { get; set; } = new ChartValues<double>();
        public string[] ColumnLabels { get; set; } = new string[labelCount];

        protected int[] _ranges;

        public string XAxisTitle { get; set; }
        public string YAxisTitle { get; set; } = "Number of people";

        public abstract void GetValues();
    }
}

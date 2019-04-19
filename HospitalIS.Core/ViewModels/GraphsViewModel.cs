using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalIS.Core.ViewModels;
using HospitalIS.Core.ViewModels.Commands;
using HospitalIS.ViewModels.Commands;
using HospitalIS.ViewModels.GraphsViewModels;


namespace HospitalIS.ViewModels
{
    public class GraphsViewModel : BaseViewModel
    {
        public Dictionary<string, BaseGraphViewModel> Graphs { get; set; } = new Dictionary<string, BaseGraphViewModel>();
        public SwitchGraphCommandWithViewModel SwitchGraphCommandWithViewModel { get; set; }
        public BaseGraphViewModel ActualGraphViewModel { get; set; }

       // public CartesianChart Chart { get; set; }
        //public GraphsViewModel(CartesianChart chart)
        //{
        //    Chart = chart;

        //    SwitchGraphCommandWithViewModel = new SwitchGraphCommandWithViewModel(this);

        //    Graphs.Add("Weight", new WeightGraphViewModel());
        //    Graphs.Add("Height", new HeightGraphViewModel());
        //    Graphs.Add("Age", new AgeGraphViewModel());
        //}
    }
}

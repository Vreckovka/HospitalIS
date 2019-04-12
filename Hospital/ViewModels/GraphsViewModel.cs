﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hospital.Models;
using Hospital.ViewModels.Commands;
using Hospital.ViewModels.GraphsViewModels;
using Hospital.Views;
using LiveCharts;
using LiveCharts.Wpf;


namespace Hospital.ViewModels
{
    public class GraphsViewModel : BaseViewModel
    {
        public Dictionary<string, BaseGraphViewModel> Graphs { get; set; } = new Dictionary<string, BaseGraphViewModel>();
        public SwitchGraphCommand SwitchGraphCommand { get; set; }
        public BaseGraphViewModel ActualGraphViewModel { get; set; }

        public CartesianChart Chart { get; set; }
        public GraphsViewModel(CartesianChart chart)
        {
            Chart = chart;

            SwitchGraphCommand = new SwitchGraphCommand(this);

            Graphs.Add("Weight", new WeightGraphViewModel());
            Graphs.Add("Height", new HeightGraphViewModel());
            Graphs.Add("Age", new AgeGraphViewModel());
        }
    }
}

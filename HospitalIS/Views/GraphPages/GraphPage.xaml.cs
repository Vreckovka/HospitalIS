using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HospitalIS.Core.ViewModels;

namespace HospitalIS.Views.GraphPages
{
    /// <summary>
    /// Interaction logic for AgePage.xaml
    /// </summary>
    public partial class GraphPage : Page
    {
        public GraphPage(int labelCout, string xAxisTitle,int gap, int minValue, string propName)
        {
            InitializeComponent();
            DataContext = new GraphViewModel(labelCout, xAxisTitle, gap, minValue, propName);
        }
    }
}

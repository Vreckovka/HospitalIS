using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using HospitalIS.ViewModels;

namespace HospitalIS.Views
{
    /// <summary>
    /// Interaction logic for GraphsPage.xaml
    /// </summary>
    public partial class GraphsPage : Page
    {
        public GraphsViewModel GraphsViewModel { get; set; }
        public GraphsPage()
        {
            InitializeComponent();


            GraphsViewModel = new GraphsViewModel();
            DataContext = GraphsViewModel;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //if (ListViewPageControl.Items.Count > 0 && ListViewPageControl.SelectedItem == null)
            //{
            //    GraphsViewModel.SwitchGraphCommandWithViewModel.Execute(ListViewPageControl.Items[0]);
            //    ((ListViewItem)ListViewPageControl.Items[0]).IsSelected = true;
            //}
        }
    }
}

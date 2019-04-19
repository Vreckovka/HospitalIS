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
using Hospital.DataContexts;
using HospitalIS.Other;
using HospitalIS.ViewModels;
using HospitalIS.Views;

namespace HospitalIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            //Generate pacients
            //PacientGenerator pacientGenerator = new PacientGenerator();
            //pacientGenerator.SerializePacients(XmlContext.XmlPath, pacientGenerator.CreatePacients(10000));

            MainWindowViewModel = new MainWindowViewModel();
            DataContext = MainWindowViewModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //if (ListViewPageControl.Items.Count > 0)
            //{
            //    MainWindowViewModel.SwitchPageCommand.Execute(ListViewPageControl.Items[0]);
            //    ((ListViewItem) ListViewPageControl.Items[0]).IconColor = true;
            //}             
        }
    }
}

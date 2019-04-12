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
using Hospital.Other;
using Hospital.ViewModels;
using Hospital.Views;

namespace Hospital
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
            //pacientGenerator.SerializePacients("..\\..\\pacients.xml", pacientGenerator.CreatePacients(10000));


            MainWindowViewModel = new MainWindowViewModel();
            DataContext = MainWindowViewModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (ListViewPageControl.Items.Count > 0)
            {
                MainWindowViewModel.SwitchPageCommand.Execute(ListViewPageControl.Items[0]);
                ((ListViewItem) ListViewPageControl.Items[0]).IsSelected = true;
            }             
        }
    }
}

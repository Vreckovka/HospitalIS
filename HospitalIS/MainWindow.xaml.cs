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
using HospitalIS.ViewModels;
using HospitalIS.Views;

namespace HospitalIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Generate pacients
            //PacientGenerator pacientGenerator = new PacientGenerator();
            //pacientGenerator.Save(XmlContext.XmlPath, pacientGenerator.CreatePacients(10000));

            DataContext = new MainWindowViewModel();
        }
    }
}

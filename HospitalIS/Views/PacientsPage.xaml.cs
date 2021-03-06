﻿using System;
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
using HospitalIS.Core.IoC;
using HospitalIS.Core.ViewModels;
using HospitalIS.DataContexts;
using HospitalIS.ViewModels;
using Autofac;
using HospitalIS.Core.DataContexts;

namespace HospitalIS.Views
{
    /// <summary>
    /// Interaction logic for PacientsPage.xaml
    /// </summary>
    public partial class PacientsPage : Page
    {
        public PacientsPage()
        {
            InitializeComponent();
            DataContext = new PacientViewModel(IoC.Container.Resolve<DataContext>()); 
        }
    }
}

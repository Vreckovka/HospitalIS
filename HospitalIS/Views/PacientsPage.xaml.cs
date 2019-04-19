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
using HospitalIS.ViewModels;

namespace HospitalIS.Views
{
    /// <summary>
    /// Interaction logic for PacientsPage.xaml
    /// </summary>
    public partial class PacientsPage : Page
    {
        public PacientViewModel PacientViewModel { get; set; } 
        public PacientsPage()
        {
            InitializeComponent();
            PacientViewModel = new PacientViewModel();
            DataContext = PacientViewModel;
        }
    }
}
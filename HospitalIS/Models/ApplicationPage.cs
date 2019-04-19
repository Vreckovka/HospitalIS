using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Shapes;
using HospitalIS.Attributes;
using HospitalIS.Converters;
using HospitalIS.UserControls;

namespace HospitalIS.Models
{
    public enum ApplicationPage
    {
        [IconStyleKey("UserIcon")]
        [Description("Pacients")]
        Pacients,
        [IconStyleKey("BarChartIcon")]
        [Description("Graphs")]
        Graphs,
        [IconStyleKey("StatisticsIcon")]
        [Description("Statistics")]
        Statistics,
    }

    

}

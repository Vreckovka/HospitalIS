using System.ComponentModel;
using HospitalIS.Core.Attributes;

namespace HospitalIS.Core.Models
{
    public enum ApplicationPages
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

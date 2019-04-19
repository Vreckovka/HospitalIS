using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalIS.Core.Converters;

namespace HospitalIS.Core.Models
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum GraphPages
    {
        [Description("Age")]
        Age,
        [Description("Height")]
        Height,
        [Description("Weight")]
        Weight
    }
}

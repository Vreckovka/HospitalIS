using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using HospitalIS.Core.Models;
using HospitalIS.Views;
using HospitalIS.Views.StatisticsPages;

namespace HospitalIS.Converters
{
    public class StatisticsPageConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                switch ((StatisticsPages)value)
                {
                    case StatisticsPages.HeavierPeople:
                        return new HeavierPeopleStatisticsPage();
                    default:
                        return null;
                }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

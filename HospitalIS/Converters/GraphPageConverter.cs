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
using HospitalIS.Views.GraphPages;

namespace HospitalIS.Converters
{
    public class GraphPageConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                switch ((GraphPages)value)
                {
                    case GraphPages.Age:
                        return new GraphPage(6, "Age range", 10,10,"Age");
                    case GraphPages.Height:
                        return new GraphPage(6, "Height range", 5, 170, "Height");
                    case GraphPages.Weight:
                        return new GraphPage(6, "Weight range", 10,60, "Weight");
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

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

namespace HospitalIS.Converters
{
    public class ApplicationPageConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                switch ((ApplicationPage)value)
                {
                    case ApplicationPage.Pacients:
                        return new PacientsPage();
                    case ApplicationPage.Graphs:
                        return new GraphsPage();
                    case ApplicationPage.Statistics:
                        return new StatisticsPage();
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

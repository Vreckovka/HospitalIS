using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace HospitalIS.Converters
{
    /// <summary>
    /// Converts birth date to years old
    /// </summary>
    public class BirthDateConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //365.242199 avrage lenght of years in gregorian calendar
            return ((DateTime)value).ToString("dd.MM.yyyy") + $" ({(int)((DateTime.Today - (DateTime)value).TotalDays / 365.242199)} years old)";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

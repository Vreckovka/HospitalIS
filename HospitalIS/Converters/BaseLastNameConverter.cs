using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using HospitalIS.Core.Models;
using HospitalIS.Core.Other;

namespace HospitalIS.Converters
{
    /// <summary>
    /// Converts last name to last name without postfixes
    /// </summary>
    public class BaseLastNameConverter : MarkupExtension, IMultiValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] != null && values[0] != DependencyProperty.UnsetValue && values[0] is Pacient)
            {
                return (((Pacient)values[0]).LastName).RemovePostfixes(((string)values[1]).Split(';'));
            }

            return "";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

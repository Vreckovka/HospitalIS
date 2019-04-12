using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using Hospital.Models;

namespace Hospital.Other
{

    public class BirthDateFormater : MarkupExtension, IValueConverter
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

    public class ImageConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //if (value != null)
            //{
            //    BitmapImage image = new BitmapImage();

            //    image.BeginInit();
            //    image.CacheOption = BitmapCacheOption.OnLoad;
            //    image.UriSource = new Uri((value.ToString()), UriKind.Absolute);
            //    image.DecodePixelWidth = 1920; // should be enough, but you can experiment
            //    image.EndInit();
            //    return image;
            //}
            if (value is System.Windows.Shapes.Path)
                return ((System.Windows.Shapes.Path)value).Data;

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }


    public class SibligsDataConverter : MarkupExtension, IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            object[] vals = new object[2];
            vals[0] = values[0];
            vals[1] = ((string)values[1]).Split(';');
            return vals;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }

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

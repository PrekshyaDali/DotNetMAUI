using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Converters : IValueConverter
    {
        object? IValueConverter.Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is float)
            {
                return (int)Math.Round((float)value);
            }
            else if (value is double)
            {
                return (int)Math.Round((double)value);
            }
            else
                return value;
        }

        object? IValueConverter.ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if ((value is float) || (value is double))
            {
                return value;
            }
            else if (value is string)
            {
                int result = 0;
                int.TryParse(value.ToString(), out result);
                return result;
            }
            return 0;
        }
    }
}

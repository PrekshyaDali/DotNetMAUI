using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class EmailValidationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string email)
            {
                Regex emailRegex = new(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                bool isValidEmail = emailRegex.IsMatch(email);
                return !isValidEmail;
            }
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}


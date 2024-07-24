using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class EmailRule<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }

        public bool Check(T value)
        {
            if (value is string str)
            {
                var isValid = !string.IsNullOrWhiteSpace(str) && str.Contains("@");
                return isValid;
            }
            return false;
        }
    }
}

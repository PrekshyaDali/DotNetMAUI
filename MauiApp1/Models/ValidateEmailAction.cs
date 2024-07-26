using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class ValidateEmailAction : TriggerAction<Entry>
    {
        public Label? InvalidEmailLabel { get; set; }

        protected override void Invoke(Entry sender)
        {
            var email = sender.Text ?? string.Empty;  

            Regex emailRegex = new(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            bool isValidEmail = emailRegex.IsMatch(email);

            if (InvalidEmailLabel != null)
            {
                InvalidEmailLabel.IsVisible = !isValidEmail && !string.IsNullOrEmpty(email);
            }
        }
    }
}

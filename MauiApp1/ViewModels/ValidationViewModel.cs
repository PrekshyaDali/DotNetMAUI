using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModels
{
    public partial class ValidationViewModel: ObservableObject
    {
        public ValidatableObject<string> Email { get; } = new();
        public ValidationViewModel()
        {
            AddValidations();
        }

        private void AddValidations()
        {
            Email.Validations.Add(new EmailRule<string>
            {
                ValidationMessage = "Invalid email address."
            });
        }

        [RelayCommand]
        private void Validate()
        {
            Email.Validate();
        }
    }
}

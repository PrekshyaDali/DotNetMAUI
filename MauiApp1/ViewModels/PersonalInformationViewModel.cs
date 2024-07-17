using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels
{
    partial class PersonalInformationViewModel : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<PersonalInformation> personalInformation = new();

        [ObservableProperty]
        private PersonalInformation info = new();
        [ObservableProperty]
        private bool isSubmitting;
        public PersonalInformationViewModel()
        {
            info = new PersonalInformation();
        }

        [RelayCommand]
        private async Task Submit()
        {
            if (Info != null)
            {
                IsSubmitting = true;
                await Task.Delay(2000);
                PersonalInformation.Add(Info);
                Info = new PersonalInformation();
                IsSubmitting= false;
            }
        }
    }
}

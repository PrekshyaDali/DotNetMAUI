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
        public PersonalInformationViewModel()
        {
            info = new PersonalInformation();
        }

        [RelayCommand]
        private void Submit()
        {
            if (Info != null)
            {
                PersonalInformation.Add(Info);
              
           Info = new PersonalInformation();
            }
        }
    }
}

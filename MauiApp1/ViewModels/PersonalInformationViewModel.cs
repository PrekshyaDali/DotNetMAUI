using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

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
        public bool isRefreshing;
        public ICommand RefreshCommand { get; }
        public PersonalInformationViewModel()
        {
            info = new PersonalInformation();
            RefreshCommand = new AsyncRelayCommand(onRefresh);
        }

        public async Task onRefresh()
        {
            await Task.Delay(1000);
            ClearPersonalInformation();
            isRefreshing = false;
        }

        private void ClearPersonalInformation()
        {
            Info.FirstName = string.Empty;
            Info.LastName = string.Empty;
            Info.Email = string.Empty;
            Info.ContactNumber = 0; 
            Info.DateOfBirth = DateTime.Now; 
            Info.Address = string.Empty;
            Info.OfficeStartHours = TimeSpan.Zero; 
            Info.OfficeEndHours = TimeSpan.Zero; 
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

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Views;
using Microsoft.Extensions.DependencyInjection;

namespace MauiApp1.ViewModels
{
    public partial class SettingsViewModel : INotifyPropertyChanged
    {
     
        private bool _IsValid;
        private readonly UserService _userService;
        private string _userName;
        private readonly IServiceProvider _serviceProvider;

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
                _userService.SetUserName(value);
            }
        }
        public bool IsValid
        {
            get => _IsValid;
            set
            {
                _IsValid = value;
                OnPropertyChanged(nameof(IsValid)); 
            }
        }

        public ICommand MyToggleCommand { get; }
        public SettingsViewModel(UserService userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;

            UserName = _userService.GetUserName();
            NavigateCommand = new RelayCommand(NavigateToProfile);
            MyToggleCommand = new RelayCommand(Toggle);
        }
        private void Toggle()
        {
            IsValid = !IsValid;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand NavigateCommand { get; }
        private async void NavigateToProfile()
        {
            try
            {
                var profilePage = _serviceProvider.GetRequiredService<ProfilePage>();
                await Application.Current.MainPage.Navigation.PushAsync(profilePage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}

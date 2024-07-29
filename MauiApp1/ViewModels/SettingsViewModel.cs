using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Views;
using Microsoft.Extensions.DependencyInjection;

namespace MauiApp1.ViewModels
{
    public partial class SettingsViewModel : INotifyPropertyChanged
    {
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

        public SettingsViewModel(UserService userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;

            UserName = _userService.GetUserName();
            NavigateCommand = new RelayCommand(NavigateToProfile);
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

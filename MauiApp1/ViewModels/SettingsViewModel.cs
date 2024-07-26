using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        private readonly UserService _userService;
        private string _userName;

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

        public SettingsViewModel(UserService userService)
        {
            _userService =  userService;
            UserName = _userService.GetUserName();

        }
        

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

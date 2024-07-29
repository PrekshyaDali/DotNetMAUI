using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private readonly UserService _userService;

        public ProfileViewModel(UserService userService)
        {
            _userService = userService;
            _userService.PropertyChanged += OnUserServicePropertyChanged;
            UserName = _userService.GetUserName();
        }
        private void OnUserServicePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(UserService.UserName))
            {
                UserName = _userService.UserName;
            }
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

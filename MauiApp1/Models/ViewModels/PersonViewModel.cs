using System;
using System.ComponentModel;

namespace MauiApp1.Models.ViewModels
{
    class PersonViewModel : INotifyPropertyChanged
    {
        private string? name;
        public string? Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    NotifyPropertyChanged(nameof(Name));
                }
            }
        }

        private int? age;
        public int? Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    NotifyPropertyChanged(nameof(Age));
                }
            }
        }

        private string? email;
        public string? Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    NotifyPropertyChanged(nameof(Email));
                }
            }
        }

        private bool isTrainee;
        public bool IsTrainee
        {
            get { return isTrainee; }
            set
            {
                if (isTrainee != value)
                {
                    isTrainee = value;
                    NotifyPropertyChanged(nameof(IsTrainee));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

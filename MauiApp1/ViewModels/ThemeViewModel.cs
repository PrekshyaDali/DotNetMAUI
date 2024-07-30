using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows.Input;
using MauiApp1.Themes;

namespace MauiApp1.ViewModels
{
    public partial class ThemeViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isDarkMode;

        public ThemeViewModel()
        {
            PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IsDarkMode))
            {
                SwitchTheme(IsDarkMode);
            }
        }

        private void SwitchTheme(bool isDarkMode)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            if (isDarkMode)
            {
                Application.Current.Resources.MergedDictionaries.Add(new DarkTheme());
            }
            else
            {
                Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
            }
        }
    }
}

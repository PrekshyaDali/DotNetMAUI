using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    internal partial class PresentDataDemoPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isChecked;
        [ObservableProperty]
        private string? status;
        [ObservableProperty]
        private DateTime selectedDate;

        public PresentDataDemoPageViewModel()
        {
            isChecked = false;
            Status = "Not checked";
            SelectedDate = DateTime.Now;
        }

        partial void OnIsCheckedChanged(bool value) {
            Status = value ? "Checked" : "Not Checked";
        }
    }
}

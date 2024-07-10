using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models.ViewModels
{
    partial class PersonViewModel2 : ObservableObject
    {
        //this will observe the changes 
        [ObservableProperty]
        private string? name;

        [ObservableProperty]
        private int age;

        [ObservableProperty]
        private string? email;
        [ObservableProperty]
        private bool isTrainee;
    }
}

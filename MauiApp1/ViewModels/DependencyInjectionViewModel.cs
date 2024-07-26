using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class DependencyInjectionViewModel:ObservableObject
    {
        private string _dependencyInjectionName = "hello from viewmodel from Prajwal";

        public string DependencyInjectionName
        {
            get => _dependencyInjectionName;
            set => SetProperty(ref _dependencyInjectionName, value);
        }

    }
}

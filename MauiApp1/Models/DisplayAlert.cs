using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    class DisplayAlert: TriggerAction<Button>
    {
        protected override async void Invoke(Button button)
        {
            await Application.Current.MainPage.DisplayAlert("Hurray", "Congrats you have added one person", "OK");
        }
    }
    }

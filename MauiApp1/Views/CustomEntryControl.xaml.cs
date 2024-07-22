using MauiApp1.Models;
using MauiApp1.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiApp1.Views
{
    public partial class CustomEntryControl : ContentPage
    {
        public CustomEntryControl()
        {
            InitializeComponent();
            BindingContext = new PersonViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CommandDemoPage());

        }
    }
}

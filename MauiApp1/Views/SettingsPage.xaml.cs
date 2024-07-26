using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        
    }
}
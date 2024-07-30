using CommunityToolkit.Mvvm.Input;
using MauiApp1.ViewModels;
using System.Diagnostics;
using System.Windows.Input;

namespace MauiApp1.Views;

public partial class SettingsPage : ContentPage

{
    private readonly IServiceProvider _serviceProvider;
	public SettingsPage(SettingsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {

        //displaying an Action sheet
        string action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
        Debug.WriteLine("Action: " + action);
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Question 1", "What's your name?", initialValue: "Prekshya" , maxLength: 3);
    }
}

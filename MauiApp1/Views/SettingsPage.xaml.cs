using CommunityToolkit.Mvvm.Input;
using MauiApp1.ViewModels;
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
    public ICommand NavigateCommand { get; set; }

 
}
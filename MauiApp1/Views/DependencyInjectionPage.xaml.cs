using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class DependencyInjectionPage : ContentPage
{
	public DependencyInjectionPage(DependencyInjectionViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

    }
}
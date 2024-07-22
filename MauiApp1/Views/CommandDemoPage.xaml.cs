using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class CommandDemoPage : ContentPage
{
	public CommandDemoPage()
	{
		InitializeComponent();
		BindingContext = new CommandDemoViewModel();
	}
}

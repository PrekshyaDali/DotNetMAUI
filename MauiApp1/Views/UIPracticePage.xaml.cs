namespace MauiApp1.Views;

using MauiApp1.Models;
using MauiApp1.ViewModels;

public partial class UIPracticePage : ContentPage
{
	public UIPracticePage()
	{
		InitializeComponent();
		BindingContext = new FairyTaleViewModel();
	}
}

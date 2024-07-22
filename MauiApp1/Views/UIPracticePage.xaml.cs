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

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.NewTextValue))
        {
            // Call the CancelCommand in ViewModel
            if (BindingContext is FairyTaleViewModel viewModel)
            {
                viewModel.OnCancel();
            }
        }

    }
}

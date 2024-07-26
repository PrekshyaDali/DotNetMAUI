using MauiApp1.Models;
namespace MauiApp1.Views;

public partial class ValidationPageDemo : ContentPage
{
	public ValidationPageDemo()
	{
		InitializeComponent();

        if (EmailFocusAction is ValidateEmailAction focusAction)
        {
            focusAction.InvalidEmailLabel = InvalidEmailLabel;
        }

        if (EmailUnfocusAction is ValidateEmailAction unfocusAction)
        {
            unfocusAction.InvalidEmailLabel = InvalidEmailLabel;
        }
    }
}

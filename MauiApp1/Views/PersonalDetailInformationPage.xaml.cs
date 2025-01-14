using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class PersonalDetailInformationPage : ContentPage
{
	public PersonalDetailInformationPage()
	{
		InitializeComponent();
		BindingContext = new PersonalInformationViewModel();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;

        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }
}

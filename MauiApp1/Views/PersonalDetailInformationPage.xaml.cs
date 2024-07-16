using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class PersonalDetailInformationPage : ContentPage
{
	public PersonalDetailInformationPage()
	{
		InitializeComponent();
		BindingContext = new PersonalInformationViewModel();
	}

    
}
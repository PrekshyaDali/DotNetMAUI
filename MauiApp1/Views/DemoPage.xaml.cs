using MauiApp1.Models.ViewModels;
namespace MauiApp1.Pages;

public partial class DemoPage : ContentPage
{ 

	public DemoPage()
	{
		InitializeComponent();
	}

	public void OnButton1Clicked(object sender, EventArgs e)
	{
        var prekshyaViewModel = new PersonViewModel2
        {
            Name = "Prekshya",
           Email = "prekshyashrestha0@gmail.com",
            Age = 20,
           IsTrainee = true,
        };
        var person = new Person();
        person.BindingContext = prekshyaViewModel;
        Navigation.PushAsync(person);

        
    }

    public void OnButton2Clicked(object sender, EventArgs e)
    {
        var prekshyaViewModel = new PersonViewModel2
        {
            Name = "Ashim",
            Email = "ashim@gmail.com",
            Age = 24,
            IsTrainee = true,
        };
        var person = new Person();
        person.BindingContext = prekshyaViewModel;
        Navigation.PushAsync(person);


    }

    public void OnButton3Clicked(object sender, EventArgs e)
    {
        var prekshyaViewModel = new PersonViewModel2
        {
            Name = "ajay",
            Email = "ajay@gmail.com",
            Age = 25,
            IsTrainee = true,
        };
        var person = new Person();
        person.BindingContext = prekshyaViewModel;
        Navigation.PushAsync(person);


    }
}
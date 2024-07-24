using MauiApp1.Models;
namespace MauiApp1.Views;

public partial class DatabaseDemoTwo : ContentPage
{
    private PersonRepository _personRepo;
    public DatabaseDemoTwo()
	{
		InitializeComponent();
        _personRepo = App.PersonRepo; 
        LoadPeople();
    }


    private void OnAddPersonClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text?.Trim();
        if (!string.IsNullOrEmpty(name))
        {
            _personRepo.AddNewPerson(name);
            StatusLabel.Text = "Person added!";
            LoadPeople(); 
        }
        else
        {
            StatusLabel.Text = "Please enter a name.";
        }
    }

    private void OnGetAllPeopleClicked(object sender, EventArgs e)
    {
        LoadPeople();
    }
    private void LoadPeople()
    {
        try
        {
            var people = _personRepo.GetAllPeople();
            PeopleListView.ItemsSource = people;
        }
        catch (Exception ex)
        {
            StatusLabel.Text = $"Failed to retrieve data. {ex.Message}";
        }
    }
}

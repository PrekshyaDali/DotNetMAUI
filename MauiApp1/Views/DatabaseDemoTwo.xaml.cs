using MauiApp1.Models;
namespace MauiApp1.Views;

public partial class DatabaseDemoTwo : ContentPage
{
    private PersonRepository _personRepo;
    private string _editPersonName = null; 
  
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
            if (_editPersonName == null)
            {
                // Add new person
                _personRepo.AddNewPerson(name);
                StatusLabel.Text = "Person added!";
            }
            else
            {
                // Edit existing person
                var person = _personRepo.GetPersonByName(_editPersonName);
                if (person != null)
                {
                    person.Name = name;
                    _personRepo.UpdatePerson(person);
                    StatusLabel.Text = "Person updated!";
                    _editPersonName = null;
                    AddEditPersonButton.Text = "Add Person";
                }
            }

            NameEntry.Text = string.Empty;
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
            PeopleListView.ItemsSource = null;
            PeopleListView.ItemsSource = people;

            if (people != null && people.Count > 0)
            {
                StatusLabel.Text = $"Loaded {people.Count} people.";
            }
            else
            {
                StatusLabel.Text = "No people found.";
            }
        }
        catch (Exception ex)
        {
            StatusLabel.Text = $"Failed to retrieve data. {ex.Message}";
        }
    }

    private async void PeopleListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if(e.Item is Person person)
        {
            var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");

            switch (action)
            {
                case "Edit":
                    _editPersonName = person.Name;
                    NameEntry.Text = person.Name;
                    AddEditPersonButton.Text = "Edit Person";
                    break;

                case "Delete":
                    _personRepo.DeletePerson(person);
                    LoadPeople();
                    break;
            }
        }
    }
}

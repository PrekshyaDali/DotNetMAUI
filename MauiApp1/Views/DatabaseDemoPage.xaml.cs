using MauiApp1.Models;
using Microsoft.Extensions.DependencyInjection;
namespace MauiApp1.Views;

public partial class DatabaseDemoPage : ContentPage
{

    private readonly LocalDbServices _localDbServices;
    private int _editPersonId;

    public DatabaseDemoPage()
    {
        InitializeComponent();
        //_localDbServices = new LocalDbServices();
        _localDbServices = new LocalDbServices();
        LoadDataAsync();
        BindingContext = this;

    }
    public DatabaseDemoPage(LocalDbServices localDbServices):this()
    {
        _localDbServices = localDbServices;
    }
    private async void LoadDataAsync()
    {
        listView.ItemsSource = await _localDbServices.GetPerson();
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (_editPersonId == 0)
        {
            await _localDbServices.Create(new PersonDbClass
            {
                PersonName = NameEntryField.Text,
                PersonAge = AgeEntryField.Text

            });
        }
        else
        {
            await _localDbServices.Update(new PersonDbClass
            {
                Id = _editPersonId,
                PersonName = NameEntryField.Text,
                PersonAge = AgeEntryField.Text

            });

            _editPersonId = 0;

            NameEntryField.Text = string.Empty;
            AgeEntryField.Text = string.Empty;

            listView.ItemsSource = await _localDbServices.GetPerson();
        }
    }

    private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
    {

        if (e.Item is PersonDbClass customer)
        {
            var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");

            switch (action)
            {
                case "Edit":
                    _editPersonId = customer.Id;
                    NameEntryField.Text = customer.PersonName;
                    AgeEntryField.Text = customer.PersonAge;
                    break;

                case "Delete":
                    await _localDbServices.Delete(customer);
                    LoadDataAsync();
                    break;
            }
        }
    }

}

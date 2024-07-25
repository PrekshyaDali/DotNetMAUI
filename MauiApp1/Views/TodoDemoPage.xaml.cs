using MauiApp1.ViewModels;
using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class TodoDemoPage : ContentPage
{
    private readonly TodoViewModel _viewModel;

    public TodoDemoPage()
    {
        InitializeComponent();
        _viewModel = new TodoViewModel();
        BindingContext = _viewModel;
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await _viewModel.LoadData();
        TodoListView.ItemsSource = _viewModel.TodoItems;
        TodoListView.IsVisible = true;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var title = NameEntryTodo.Text;
        var completed = CompletedEntryTodo.IsToggled;
        var userId = Convert.ToInt16(UserIDEntryField.Text);
        var id = Convert.ToInt16(IdEntryField.Text);
        var newItem = new TodoItem
        {
            title = title,
            completed = completed,
            userId = userId,
            id = id,
        };

        await _viewModel.AddTodoItem(newItem);
        await _viewModel.LoadData();
        TodoListView.ItemsSource = _viewModel.TodoItems;
        TodoListView.IsVisible = true;

        await DisplayAlert("Success", "You have added a new Todo item.", "OK");

        // Clearing the entry fields
        NameEntryTodo.Text = string.Empty;
        CompletedEntryTodo.IsToggled = false;
        UserIDEntryField.Text = string.Empty;
        IdEntryField.Text = string.Empty;
    }
}

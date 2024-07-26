using MauiApp1.ViewModels;
using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class TodoDemoPage : ContentPage
{
    private readonly TodoViewModel _viewModel;
    private TodoItem _editingItem;

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

        bool isSuccess;

        if (_editingItem == null)
        {
            // Adding a new Todo item
            isSuccess = await _viewModel.AddTodoItem(newItem);
            if (isSuccess)
            {
                await DisplayAlert("Success", "Todo item added successfully.", "OK");
            }
            else
            {
                await DisplayAlert("Failed", "Failed to add Todo item.", "OK");
            }
        }
        else
        {
            newItem.id = _editingItem.id; 
            isSuccess = await _viewModel.UpdateTodoItem(newItem);
            if (isSuccess)
            {
                await DisplayAlert("Success", "Todo item updated successfully.", "OK");
                AddButton.Text = "Add Todo";

            }
            else
            {
                await DisplayAlert("Failed", "Failed to update Todo item.", "OK");
            }
            _editingItem = null; 
        }

        // Reload data and update the UI
        await _viewModel.LoadData();
        TodoListView.ItemsSource = _viewModel.TodoItems;
        TodoListView.IsVisible = true;

        // Clear the entry fields
        NameEntryTodo.Text = string.Empty;
        CompletedEntryTodo.IsToggled = false;
        UserIDEntryField.Text = string.Empty;
        IdEntryField.Text = string.Empty;
    }

    private async void TodoListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        //inprogress
        if (e.Item is TodoItem todoItem)
        {
            var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");

            switch (action)
            {
                case "Edit":
                    _editingItem = todoItem;
                    NameEntryTodo.Text = todoItem.title;
                    CompletedEntryTodo.IsToggled = todoItem.completed;
                    UserIDEntryField.Text = todoItem.userId.ToString();
                    IdEntryField.Text = todoItem.id.ToString();
                    AddButton.Text = "Update Todo";
                    break;


                case "Delete":
                  bool isSuccess = await _viewModel.DeleteTodoItem(todoItem.id);
                    if (isSuccess)
                    {
                        await DisplayAlert("Success", "Todo Item Deleted successfully.", "OK");
                    }
                    else
                    {
                        await DisplayAlert("Failed", "Todo Item Deletion failed.", "OK");
                    }
                    await _viewModel.LoadData();
                    TodoListView.ItemsSource= _viewModel.TodoItems;
                    break;

            }
        }
    }
}

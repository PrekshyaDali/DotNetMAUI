using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class TodoViewModel
    {
        private RestService _restService;
        public ObservableCollection<TodoItem> TodoItems { get; private set; }

        public TodoViewModel()
        {
            _restService = new RestService();
            TodoItems = new ObservableCollection<TodoItem>();
        }

        public async Task LoadData()
        {
            var items = await _restService.GetTodoItemsAsync();
            foreach (var item in items)
            {
                TodoItems.Add(item);
            }
        }

        public async Task AddTodoItem(TodoItem item)
        {
            await _restService.AddTodoItemAsync(item);
            TodoItems.Add(item);
           
        }

        public async Task UpdateTodoItem(TodoItem item)
        {
            await _restService.UpdateTodoItemAsync(item);
            var existingItem = TodoItems.FirstOrDefault(i => i.id == item.id);
            if (existingItem != null)
            {
                existingItem.title = item.title;
                existingItem.completed = item.completed;
            }
        }
    }
}

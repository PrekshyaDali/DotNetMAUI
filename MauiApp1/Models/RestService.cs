using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MauiApp1.Models;

namespace MauiApp1.Models
{
    public class RestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        public List<TodoItem> Items { get; set; }
        public RestService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,

            };
        }


      public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            var uri = new Uri(Constants.RestUrl);
            List<TodoItem> items = new List<TodoItem>();

            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonSerializer.Deserialize<List<TodoItem>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR: {ex.Message}");
            }
            return items;
        }


        public async Task AddTodoItemAsync(TodoItem item)
        {
            var uri = new Uri(Constants.RestUrl);
            string json = JsonSerializer.Serialize(item, _serializerOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _client.PostAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Item added successfully.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR: {ex.Message}");
            }
        }

        public async Task UpdateTodoItemAsync(TodoItem item)
        {
            var uri = new Uri($"{Constants.RestUrl}/{item.id}");
            string json = JsonSerializer.Serialize(item, _serializerOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _client.PutAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Item updated successfully.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ERROR: {ex.Message}");
            }
        }

    }
}

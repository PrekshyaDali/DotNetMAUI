using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public ApiService(string apiKey)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.themoviedb.org/3/")
            };
            _apiKey = apiKey;
        }

        public async Task<string> GetMovieDataAsync(int movieId)
        {
            string url = $"movie/{movieId}?api_key={_apiKey}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception("Failed to retrieve data");
            }
        }
    }
}

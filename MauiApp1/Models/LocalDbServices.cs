using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;

namespace MauiApp1.Models
{
    public class LocalDbServices
    {
        private const string DB_Name = "demo_local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbServices()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_Name));
            CreateTableAsync().Wait();
        }

        private async Task CreateTableAsync()
        {
            try
            {
                await _connection.CreateTableAsync<PersonDbClass>();
                Console.WriteLine("Table created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during table creation: {ex.Message}");
            }

        }
        public async Task<List<PersonDbClass>> GetPerson()
        {

            return await _connection.Table<PersonDbClass>().ToListAsync();

        }

        public async Task<PersonDbClass> GetById(int id)
        {
            return await _connection.Table<PersonDbClass>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(PersonDbClass person)
        {
            await _connection.InsertAsync(person);
        }

        public async Task Update(PersonDbClass person)
        {
            await _connection.UpdateAsync(person);
        }

        public async Task Delete(PersonDbClass person)
        {
            await _connection.DeleteAsync(person);
        }
    }
}

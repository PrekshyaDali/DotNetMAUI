﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class PersonRepository
    {
        private SQLiteConnection conn;
        private readonly string _dbPath;

        public PersonRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.DropTable<Person>();
            conn.CreateTable<Person>();
        }

        public void AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                Init();

                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                result = conn.Insert(new Person { Name = name });
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to add {name}. Error: {ex.Message}";
            }
        }

        public List<Person> GetAllPeople()
        {
            try
            {
                Init();
                return conn.Table<Person>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to retrieve data. {ex.Message}";
            }

            return new List<Person>();
        }

        public void UpdatePerson(Person person)
        {
            try
            {
                Init();
                conn.Update(person);
                
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to update person. Error: {ex.Message}";
            }
        }

        public void DeletePerson(Person person)
        {
            try
            {
                Init();
                conn.Delete(person);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to delete person. Error: {ex.Message}";
            }
        }

        public Person GetPersonByName(string name)
        {
            try
            {
                Init();
                return conn.Table<Person>().FirstOrDefault(p => p.Name == name);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to retrieve person. {ex.Message}";
                return null;
            }
        }

        public string StatusMessage { get; private set; }
    }
}

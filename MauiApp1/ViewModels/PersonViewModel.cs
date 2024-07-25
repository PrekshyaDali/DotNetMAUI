using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    class PersonViewModel
    {
        public ObservableCollection<Person> People {get; set;}

        public PersonViewModel()
        {
            People = new ObservableCollection<Person>
            {
               new Person {Id= 1, Name = null, Age = 20 },
               new Person {Id= 2, Name = "Bitisha Maharjan", Age = 19},
               new Person {Id= 3,Name = "Suyan HeroHeralal", Age = 78}
            };
            
        }
    }
}

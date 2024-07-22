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
               new Person { Name = null, Age = 20 },
               new Person {Name = "Bitisha Maharjan", Age = 19},
               new Person {Name = "Suyan HeroHeralal", Age = 78}
            };
            
        }
    }
}

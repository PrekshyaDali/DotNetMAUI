﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Person
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class TodoItem
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string? title { get; set; }
        public bool completed { get; set; }

    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{

    [Table("person")]
    public class PersonDbClass
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("person_name")]
        public string? PersonName { get; set; }

        [Column ("person_age")]
        public string? PersonAge {  get; set; }
    }
}

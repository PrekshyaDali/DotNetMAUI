using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class PersonalInformation
    {
         public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public long? ContactNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public TimeSpan OfficeStartHours { get; set; }
        public TimeSpan OfficeEndHours { get; set; }

    }
}

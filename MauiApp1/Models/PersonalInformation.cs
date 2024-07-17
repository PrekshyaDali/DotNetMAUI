using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class PersonalInformation
    {

        //[Display (Name = "firstname", Prompt ="firstname")]
        //[Required (AllowEmptyStrings =false, ErrorMessage ="First name should not be empty")]
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

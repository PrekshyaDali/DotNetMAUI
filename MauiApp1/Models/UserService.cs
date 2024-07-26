using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class UserService
    {
        private string _username = "Prekshya";

        public string GetUserName()
        {
            return _username;
        }
        public void SetUserName (string username)
        {
            _username = username;
        }

    }
}

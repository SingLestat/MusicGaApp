using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGaApp.ViewModels
{
    class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }

        public bool checkInfo()
        {
            if (!this.Email.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}

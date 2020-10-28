using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGaApp.Model
{
    public class UserInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string Password { get; set; }

    }
}

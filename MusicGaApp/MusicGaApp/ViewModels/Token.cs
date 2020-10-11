using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGaApp.ViewModels
{
    public class Token
    {
        public int Id { get; set; }
        public string access_token { get; set; }
        public string expire_date { get; set; }

        public Token() { }
    }
}

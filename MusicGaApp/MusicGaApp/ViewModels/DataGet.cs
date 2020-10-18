using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGaApp.ViewModels
{
    class DataGet
    {
        public static List<string> GetIndustryList()
        {
            List<string> Industry = new List<string> { "Other" };

            //add to list all Industry in database

            return Industry;
        }
    }
}

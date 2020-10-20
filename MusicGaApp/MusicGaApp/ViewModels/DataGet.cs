using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MusicGaApp.ViewModels
{
    class DataGet
    {
        private void GetConnection(string Command)
        {
            string connetionString = Command;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cnn.Close();
        }

        public static List<string> GetIndustryList()
        {
            List<string> Industry = new List<string> { "Other" };

            //add to list all Industry in database

            return Industry;
        }

        public static bool uniqueUser(string email)
        {
            //check if email is in database
            if(true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

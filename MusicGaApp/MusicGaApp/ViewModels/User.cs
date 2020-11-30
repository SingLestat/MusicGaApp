using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MusicGaApp.ViewModels
{
    class User
    {
        public static int Id { get; set; }
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
   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [User] WHERE EMAIL='" + Email + "' AND PASSWORD ='" + Password + "'", Constants.conn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //getUserId(Email);
                return true;
            }
            else
                return false;
        }

        public static bool checkSpecialChar(string word)
        {
            foreach (var item in Constants.specialChar)
            {
                if (word.Contains(item)) return true;
            }

            return false;
        }

        public static void getUserId(string email)
        {
            using (SqlConnection conn = new SqlConnection(Constants.conn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT USER_ID FROM [dbo].[User] Where EMAIL = " + email + "", conn))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Id = (int)dr[0];
                        }
                    }
                }

                conn.Close();
            }
        }
    }
}

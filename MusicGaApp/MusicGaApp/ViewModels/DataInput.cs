using MusicGaApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MusicGaApp
{
    class DataInput
    {
        private static void InsertConnection(string Command)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection(Constants.ConnectionString);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = Command;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public static void InputUser(string fName, string lName, string email, string password)
        {
            string insert = "INSERT user (FirstName, LastName, Email, Password) VALUES ('" + fName + "','" + lName + "','" + email + "','" + password + "')";

            InsertConnection(insert);
        }

        public static void InputCompany(string company, string owner, string street, string city, string state, string zip, string website, string industry, string bio)
        {
            string insertbusiness = "INSERT business (Business_Name, Address, Area/County/Zipcode, Business_Category) VALUES ('" + company + "','" + street + " " + city + " " + state + "','" + industry + "')";
            string insertOwner = "INSERT business_owner (Owner_Name) VALUES ('" + owner + "')";

            InsertConnection(insertbusiness);
            InsertConnection(insertOwner);
        }
    }
}

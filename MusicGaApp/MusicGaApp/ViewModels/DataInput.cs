using MusicGaApp.ViewModels;
using MySqlConnector;
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
            using (MySqlConnection conn = new MySqlConnection(Constants.ConnectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(Command);
                command.ExecuteNonQuery();
            }
        }

        public static void InputUser(string fName, string lName, string email, string password)
        {
            //string insert = "INSERT user (FirstName, LastName, Email, Password) VALUES ('" + fName + "','" + lName + "','" + email + "','" + password + "')";

            string insert = "INSERT user (Username, Bio, Email, Password, Web links) VALUES ('" + fName + "','" + lName + "','" + email + "','" + password + "' ,'" + password + "','" + password + "')";

            InsertConnection(insert);
        }

        public static void InputCompany(string company, string ownerFname,string ownerLname, string street, string city, string state, string zip, string website, string industry, string bio)
        {
            //string insertbusiness = "INSERT business (Business_Name, Address, Area/County/Zipcode, Business_Category) VALUES ('" + company + "','" + street + " " + city + " " + state + "','" + industry + "')";
            //string insertOwner = "INSERT business_owner (Owner_Name) VALUES ('" + owner + "')";

            //InsertConnection(insertbusiness);
            //InsertConnection(insertOwner);
        }

        public static void InputArtist(string Stagename, string fname, string lname, string street, string city, string state, string zip, string website, string genre, string bio)
        {
            //string insertbusiness = "INSERT business (Business_Name, Address, Area/County/Zipcode, Business_Category) VALUES ('" + company + "','" + street + " " + city + " " + state + "','" + industry + "')";
            //string insertOwner = "INSERT business_owner (Owner_Name) VALUES ('" + owner + "')";

            //nsertConnection(insertbusiness);
           // InsertConnection(insertOwner);
        }

        public static void InputEvent(string eventName, string fname, string lname, string street, string city, string state, string zip, string website, string Data, string time, string bio)
        {
            //string insertbusiness = "INSERT business (Business_Name, Address, Area/County/Zipcode, Business_Category) VALUES ('" + company + "','" + street + " " + city + " " + state + "','" + industry + "')";
            //string insertOwner = "INSERT business_owner (Owner_Name) VALUES ('" + owner + "')";

            //nsertConnection(insertbusiness);
            // InsertConnection(insertOwner);
        }

        public static void InputVenue(string eventName, string fname, string lname, string street, string city, string state, string zip, string website, string bio)
        {
            //string insertbusiness = "INSERT business (Business_Name, Address, Area/County/Zipcode, Business_Category) VALUES ('" + company + "','" + street + " " + city + " " + state + "','" + industry + "')";
            //string insertOwner = "INSERT business_owner (Owner_Name) VALUES ('" + owner + "')";

            //nsertConnection(insertbusiness);
            // InsertConnection(insertOwner);
        }
    }
}

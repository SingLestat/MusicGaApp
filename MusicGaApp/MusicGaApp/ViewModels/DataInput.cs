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
        private static Random randomNum = new Random();

        private static void InsertConnection(SqlCommand Command)
        {
            using (SqlConnection conn = new SqlConnection(Constants.conn))
            {
                conn.Open();
                Command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void InputUser(string fName, string lName, string email, string password, string gender, string phone, string address, string city, string state,string zip, DateTime date, string photoUrl)
        {
            string insert = "INSERT INTO [dbo].[User] VALUES (@id, @firstName, @lastName, @email, @password, @gender, @DOB, @phone, @photoURL, @street, @city, @state, @Zipcode);";

            SqlConnection conn = new SqlConnection(Constants.conn);

            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(insert, conn);

            sqlCommand.Parameters.AddWithValue("@id", randomNum.Next());
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@password", password);
            sqlCommand.Parameters.AddWithValue("@firstName", fName);
            sqlCommand.Parameters.AddWithValue("@lastName", lName);
            sqlCommand.Parameters.AddWithValue("@gender", gender);
            sqlCommand.Parameters.AddWithValue("@DOB", date);
            sqlCommand.Parameters.AddWithValue("@phone", phone);
            sqlCommand.Parameters.AddWithValue("@photoURL", photoUrl);
            sqlCommand.Parameters.AddWithValue("@street", address);
            sqlCommand.Parameters.AddWithValue("@city", city);
            sqlCommand.Parameters.AddWithValue("@state", state);
            sqlCommand.Parameters.AddWithValue("@Zipcode", zip);


            InsertConnection(sqlCommand);

            conn.Close();
        }

        public static void InputCompany(string company, string ownerFname,string ownerLname, string street, string city, string state, string zip, string website, string industry, string bio)
        {
            //string insertbusiness = "INSERT business (Business_Name, Address, Area/County/Zipcode, Business_Category) VALUES ('" + company + "','" + street + " " + city + " " + state + "','" + industry + "')";
            //string insertOwner = "INSERT business_owner (Owner_Name) VALUES ('" + owner + "')";

            //InsertConnection(insertbusiness);
            //InsertConnection(insertOwner);
        }

        public static void InputArtist(string Stagename, string music_genre, string music_sub_genre, string artist_email, string handle_instagram, string handle_facebook, string handle_twitter, string artist_website)
        {
            string insert = "INSERT INTO [dbo].[Artist] VALUES (@id, @artist_name, @music_genre, @music_sub_genre, @artist_email, @handle_instagram, @handle_facebook, @handle_twitter, @artist_website);";

            SqlConnection conn = new SqlConnection(Constants.conn);

            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(insert, conn);

            sqlCommand.Parameters.AddWithValue("@id", randomNum.Next());
            sqlCommand.Parameters.AddWithValue("@artist_name", Stagename);
            sqlCommand.Parameters.AddWithValue("@music_genre", music_genre);
            sqlCommand.Parameters.AddWithValue("@music_sub_genre", music_sub_genre);
            sqlCommand.Parameters.AddWithValue("@artist_email", artist_email);
            sqlCommand.Parameters.AddWithValue("@handle_instagram", handle_instagram);
            sqlCommand.Parameters.AddWithValue("@handle_facebook", handle_facebook);
            sqlCommand.Parameters.AddWithValue("@handle_twitter", handle_twitter);
            sqlCommand.Parameters.AddWithValue("@artist_website", artist_website);

            InsertConnection(sqlCommand);

            conn.Close();
        }

        public static void InputEvent(string eventName, string fname, string lname, string street, string city, string state, string zip, string website, string Data, string time, string bio)
        {
            //string insertbusiness = "INSERT business (Business_Name, Address, Area/County/Zipcode, Business_Category) VALUES ('" + company + "','" + street + " " + city + " " + state + "','" + industry + "')";
            //string insertOwner = "INSERT business_owner (Owner_Name) VALUES ('" + owner + "')";

            //nsertConnection(insertbusiness);
            // InsertConnection(insertOwner);
        }

        public static void InputVenue(string venueName, string fname, string lname, string email, string phone, string webURL, string street, string city, string state, string zip)
        {
            string insert = "INSERT INTO [dbo].[Venue] VALUES (@id, @venueName, @firstName, @lastName, @email, @phone, @weblink, @street, @city, @state, @Zipcode, @userId);";

            SqlConnection conn = new SqlConnection(Constants.conn);

            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(insert, conn);

            sqlCommand.Parameters.AddWithValue("@id", randomNum.Next());
            sqlCommand.Parameters.AddWithValue("@venueName", venueName);
            sqlCommand.Parameters.AddWithValue("@firstName", fname);
            sqlCommand.Parameters.AddWithValue("@lastName", lname);
            sqlCommand.Parameters.AddWithValue("@phone", phone);
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@weblink", webURL);
            sqlCommand.Parameters.AddWithValue("@street", street);
            sqlCommand.Parameters.AddWithValue("@city", city);
            sqlCommand.Parameters.AddWithValue("@state", state);
            sqlCommand.Parameters.AddWithValue("@Zipcode", zip);
            sqlCommand.Parameters.AddWithValue("@userId", User.Id);

            InsertConnection(sqlCommand);

            conn.Close();
        }
    }
}

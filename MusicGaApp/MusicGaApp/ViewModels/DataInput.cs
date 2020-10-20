using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MusicGaApp
{
    class DataInput
    {
        private void InsertConnection(string Command)
        {
            string connetionString = Command;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cnn.Close();
        }

        public static void InputUser(string fName, string lName, string email, string password)
        {

        }
    }
}

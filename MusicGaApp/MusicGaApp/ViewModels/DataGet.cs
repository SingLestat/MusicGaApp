using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MusicGaApp.ViewModels
{
    class DataGet
    {
        private static List<string> Industry = new List<string> { "Other" };

        private void GetConnection(string Command)
        {
            string connetionString = Command;
            SqlConnection cnn;
            connetionString = Constants.ConnectionString;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cnn.Close();
        }

        public static bool LoadData()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Constants.ConnectionString))
                {
                    string commandText = @"
                    SELECT Business_Category As Industry FROM [mydb].[business]; ";
                 
                    using (SqlCommand cmd = new SqlCommand(commandText, cn))
                    {

                        cn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        // get results into first list from first select
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Industry.Add(reader.GetString(0));
                            }

                            // move on to second select
                            reader.NextResult();
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    public static List<string> GetIndustryList()
        {
            LoadData();

            return Industry;
        }

        public static bool uniqueUser(string email)
        {
            SqlConnection cnn;
            string connetionString = Constants.ConnectionString;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            using (var sqlCommand = new SqlCommand("SELECT COUNT(*) FROM User WHERE ([email] = '" + email + "'", cnn))
            {

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    //Record Already Exists
                    reader.Close();
                    reader.Dispose();
                    return false;

                }
                else
                {
                    //Record does not Exists
                    reader.Close();
                    reader.Dispose();
                    return true;
                }
            }
        }
    }
}

using MySqlConnector;
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
            using (MySqlConnection conn = new MySqlConnection(Constants.ConnectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(Command);
                command.ExecuteNonQuery();
            }
        }

        public static bool uniqueUser(string email)
        {
                string sql = "SELECT COUNT(*) FROM User WHERE Email = @a";
                using (MySqlConnection conn = new MySqlConnection(Constants.ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", email);
                        var result = Convert.ToInt32(cmd.ExecuteScalar());
                        if (result > 0)
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
    }
}

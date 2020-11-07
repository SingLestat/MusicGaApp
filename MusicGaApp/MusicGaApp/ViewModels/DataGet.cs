using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MusicGaApp.ViewModels
{
    class DataGet
    {
        private static List<string> Industry = new List<string> { "Other" };

        public static bool uniqueUser(string email)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [User] WHERE EMAIL='" + email + "'", Constants.conn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static List<string> GetDatabaseList(string colName, string table)
        {
            List<string> list = new List<string>();

            using (Constants.conn)
            {
                Constants.conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT " + colName + " FROM [dbo].[" + table + "]", Constants.conn))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }

                Constants.conn.Close();
            }
            return list;
        }

        public static List<string> GetDatabaseList(string selectedItem, string Table, string ColName)
        {
            List<string> list = new List<string>();
            List<string> listCol = new List<string>();
            List<string> listInfo = new List<string>();

            using (SqlConnection conn = new SqlConnection("Data Source = gamusicserver.database.windows.net; Initial Catalog = GaMusicDB; User ID = GGteam4; Password = P@ssword!; Connect Timeout = 60; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[" + Table + "] WHERE " + ColName + " = '" + selectedItem + "'", conn))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int c = 0; c < dr.FieldCount; c++)
                            {
                                listInfo.Add(dr[c].ToString());
                            }
                        }
                    }
                }

                conn.Close();

                using (SqlConnection conn1 = new SqlConnection("Data Source = gamusicserver.database.windows.net; Initial Catalog = GaMusicDB; User ID = GGteam4; Password = P@ssword!; Connect Timeout = 60; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;"))

                {
                    conn1.Open();

                    using (SqlCommand cmd = new SqlCommand("select column_name from information_schema.columns where table_name = '"+Table+"'", conn1))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                listCol.Add(dr[0].ToString());
                            }
                        }
                    }

                    conn1.Close();
                }

                for (int x = 0; x < listCol.Count; x++)
                {
                    list.Add(listCol[x].ToString() + ": " + listInfo[x].ToString());
                }
            }
            return list;

        }
    }
}

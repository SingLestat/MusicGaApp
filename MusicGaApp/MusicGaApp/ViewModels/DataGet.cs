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
            SqlConnection conn = new SqlConnection(Constants.conn);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [User] WHERE EMAIL='" + email + "'", conn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }
        }

        public static int nextTABLEid(string table)
        {
            SqlConnection conn = new SqlConnection(Constants.conn);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [" + table + "]", conn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
             
            sda.Fill(dt);
            return  (int)dt.Rows[0][0] +  1;

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

            using (SqlConnection conn = new SqlConnection(Constants.conn))
            {
               conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT " + colName + " FROM [dbo].[" + table + "]", conn))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }

                    }
                }
            }
            return list;
        }

        public static List<string> GetIndustry()
        {
            List<string> list = new List<string>();

            using (SqlConnection conn = new SqlConnection(Constants.conn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT MUSIC_BUSINESS_SUBCATEGORY FROM [dbo].[Business]", conn))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;
        }

        public static List<string> Getgenre()
        {
            List<string> list = new List<string>();

            using (SqlConnection conn = new SqlConnection(Constants.conn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT MUSIC_GENRE FROM [dbo].[Music]", conn))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;
        }

        public static List<string> Getsubgenre(string genre)
        {
            List<string> list = new List<string>();

            using (SqlConnection conn = new SqlConnection(Constants.conn))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT MUSIC_SUB_GENRE FROM [dbo].[Music] WHERE MUSIC_GENRE ='" + genre + "'", conn))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;
        }

        public static List<string> GetDatabaseListVenue(string selectedItem, string Table, string ColName)
        {
            List<string> list = new List<string>();
            List<string> listCol = new List<string>();
            List<string> listInfo = new List<string>();

            using (SqlConnection conn = new SqlConnection(Constants.conn))
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

                using (SqlConnection conn1 = new SqlConnection(Constants.conn))
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
                conn.Close();

                list.Add("Venue Name: " + listInfo[1].ToString());
                list.Add("Owner's Name: " + listInfo[2].ToString());
                list.Add("Phone Number: " + listInfo[4].ToString());
                list.Add("Email: " + listInfo[3].ToString());
                list.Add("Website: " + listInfo[5].ToString());
                list.Add("Venue's Address: " + listInfo[6].ToString() + " " + listInfo[7].ToString() + ", " + listInfo[8].ToString() + " " + listInfo[9].ToString());
            }
            return list;
        }

        public static List<string> GetDatabaseListArtist(string selectedItem, string Table, string ColName)
        {
            List<string> list = new List<string>();
            List<string> listCol = new List<string>();
            List<string> listInfo = new List<string>();

            using (SqlConnection conn = new SqlConnection(Constants.conn))
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
                using (SqlConnection conn1 = new SqlConnection(Constants.conn))
                {
                    conn1.Open();
                    using (SqlCommand cmd = new SqlCommand("select column_name from information_schema.columns where table_name = '" + Table + "'", conn1))
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
                conn.Close();

                list.Add("Artist Name: " + listInfo[1].ToString());
                list.Add("Genre: " + listInfo[2].ToString() + " Sub-Genre:" + listInfo[3].ToString());
                list.Add("Email: " + listInfo[4].ToString());
                list.Add("Instagram: " + listInfo[5].ToString());
                list.Add("Facebook: " + listInfo[6].ToString());
                list.Add("Twitter: " + listInfo[7].ToString());
                list.Add("Personal Website: " + listInfo[8].ToString());
            }
            return list;
        }
    }
}

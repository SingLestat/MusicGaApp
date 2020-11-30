using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Xamarin.Forms;


namespace MusicGaApp.ViewModels
{
    public class Constants
    {
        public static bool IsDev = true;

        public static Color Background = Color.Black;
        public static Color MainTextColor = Color.White;

        public static int LoginIconHeight = 120;

        public static List<String> States = new List<string> { "Alabama", "Alaska", "American Samoa", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Federated States of Micronesia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Marshall Islands", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Northern Mariana Islands", "Ohio", "Oklahoma", "Oregon", "Palau", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Island", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };

        public static List<String> Industry = new List<string> { "Singer", "DJ", "Music Producer", "Songwriter", "Sound Technician", "Lyricist", "Record Producer" };

        public static string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";


        public static string conn = "Server=tcp:website-db-server.database.windows.net,1433;Initial Catalog=Website-DB;Persist Security Info=False;User ID=localadmin;Password=P@ssword!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}

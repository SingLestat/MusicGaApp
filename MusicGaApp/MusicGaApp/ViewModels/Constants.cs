using System;
using System.Collections.Generic;
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

        public static List<string> Genres = new List<string> { "Avant_Garde", "Blues", "Children", "Classical", "Comedy", "Spoken", "Comedy", "Easy Listening", "Electronic", "Folk", "Holiday", "International", "Jazz", "Latin", "New Age", "Pop", "Rock", "R&B", "Reggae", "Religious", "Stage", "Vocal" };
        public static List<String> Avant_Garde = new List<string> { "Computer Music", "Conceptual Art", "Experimental", "Improvisation", "Microtonal", "Minimalism", "Mixed Media", "Modern Composition", "Noise", "Post-Minimalism", "Sound Art", "Tape" };
        public static List<String> Blues = new List<string> { "Blues", "Acoustic Blues", "Acoustic Chicago", "Acoustic Memphis", "Acoustic Texas Blues", "Gospel", "Revival", "Chicago Blues", "Classic Female Blues", "Contemporary Blues", "Country Blues", "Delta Blues", "Detroit Blues", "Early Acoustic Blues", "Early American Blues", "East Coast Blues", "Electric Blues", "Electric Chicago Blues", "Electric Country Blues", "Electric Delta Blues", "Electric Harmonica Blues", "Electric Texas Blues", "Folk - Blues", "Harmonica Blues", "Jazz Blues", "Juke Joint Blues", "Jump Blues", "Jump Blues", "Piano Blues", "Louisiana Blues", "Memphis Blues", "Modern Acoustic Blues", "Modern Blues", "Modern Delta Blues", "Modern Electric Blues", "Modern Electric Chicago Blues", "Modern Electric Texas Blues", "New Orleans Blues", "Piano Blues", "Piedmont Blues", "Pre - War Blues", "Pre - War Country Blues", "Pre - War Gospel Blues", "Regional Blues", "Slide Guitar Blues", "Songster", "Soul - Blues", "Swamp Blues", "Texas Blues", "Urban Blues", "Vaudeville Blues", "West Coast Blues", "Work Songs" };
        public static List<String> Children = new List<string> { "Children", "Children's Folk", "Children's Pop", "Children's Rock",  "Educational", "Lullabies",  "Sing-Alongs"};
        public static List<String> Classical = new List<string> { "Classical", "Avant-Garde Music", "Ballet", "Band Music", "Chamber Music", "Choral", "Classical Crossover", "Concerto", "Electronic/Computer Music", "Film Score", "Keyboard", "Miscellaneous", "Opera", "Orchestral", "Show/Musical", "Symphony", "Vocal Music"};
        public static List<String> Comedy = new List<string> { "Comedy" };
        public static List<String> Spoken = new List<string> { "Spoken" };
        public static List<String> Country = new List<string> { "Country" };
        public static List<String> Easy_Listening = new List<string> { "Easy Listening" };
        public static List<String> Electronic = new List<string> { "Electronic" };
        public static List<String> Folk = new List<string> { "Folk" };
        public static List<String> Holiday = new List<string> { "Holiday" };
        public static List<String> International = new List<string> { "International" };
        public static List<String> Jazz = new List<string> { "Jazz" };
        public static List<String> Latin = new List<string> { "Latin" };
        public static List<String> New_Age = new List<string> { "New Age" };
        public static List<String> Pop = new List<string> { "Pop" };
        public static List<String> Rock = new List<string> { "Rock" };
        public static List<String> RandB = new List<string> { "R&B" };
        public static List<String> Reggae = new List<string> { "Reggae" };
        public static List<String> Religious = new List<string> { "Religious" };
        public static List<String> Stage = new List<string> { "Stage" };
        public static List<String> Vocal = new List<string> { "Vocal" };

        public static List<String> Industry = new List<string> { "Singer", "DJ", "Music Producer", "Songwriter", "Sound Technician", "Lyricist", "Record Producer" };

        public static string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

        public static string ConnectionString = "User=GaMusicTeam;Password=admin@GGteam4;Database=NorthWind;Server=40.76.249.64;Port=3306;";


    }
}

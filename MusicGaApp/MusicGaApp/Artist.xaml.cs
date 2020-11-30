using MusicGaApp.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicGaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Artist : ContentPage
    {
        private string Genre;
        public Artist()
        {
            InitializeComponent();

            genre.ItemsSource = DataGet.Getgenre();
            subGenre.ItemsSource = DataGet.Getgenre();
        }

        async void Register_Clicked(object sender, EventArgs e)
        {
            string facebook = "";
            string instagram = "";
            string twitter = "";
            string website = "";



            if (genre.SelectedIndex == -1 || subGenre.SelectedIndex == -1 || string.IsNullOrWhiteSpace(stageNameEntry.Text) || string.IsNullOrWhiteSpace(emailEntry.Text))
            {
                await DisplayAlert("Registration", "Please Enter Information.", "OK");
                return;
            }
            else
            {
                string stagename = stageNameEntry.Text;
                string email = emailEntry.Text;

                if (string.IsNullOrWhiteSpace(FacebookURLEntry.Text))
                {
                    website = "none";
                }
                else
                {
                    website = artistURLEntry.Text;

                }

                if (string.IsNullOrWhiteSpace(FacebookURLEntry.Text))
                {
                    facebook = "none";
                }
                else
                {
                    facebook = FacebookURLEntry.Text;
                }

                if (string.IsNullOrWhiteSpace(InstagramURLEntry.Text))
                {
                    instagram = "none";
                }
                else
                {
                    instagram = InstagramURLEntry.Text;
                }

                if (string.IsNullOrWhiteSpace(TwitterURLEntry.Text))
                {
                    twitter = "none";
                }
                else
                {
                    twitter = TwitterURLEntry.Text;
                }

                Genre = genre.SelectedItem.ToString();
                string subgenre = subGenre.SelectedItem.ToString();

                DataInput.InputArtist(stagename, Genre, subgenre, email, instagram, facebook, twitter, website);

                await DisplayAlert("Registration", "Your Registration will be reviewed.", "OK");
                return;
            }
        }

        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), false);
        }

        private void genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre = genre.SelectedItem.ToString();

            subGenre.ItemsSource = DataGet.Getsubgenre(Genre);
        }
    }
}
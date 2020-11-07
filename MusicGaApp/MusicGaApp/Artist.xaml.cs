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

            State.ItemsSource = Constants.States;
            genre.ItemsSource = Constants.Genres;
        }

        async void Register_Clicked(object sender, EventArgs e)
        {
            if (State.SelectedIndex == -1 || genre.SelectedIndex == -1 || string.IsNullOrWhiteSpace(stageNameEntry.Text) || string.IsNullOrWhiteSpace(entry_First.Text) || string.IsNullOrWhiteSpace(entry_Last.Text) || string.IsNullOrWhiteSpace(zipEntry.Text) || string.IsNullOrWhiteSpace(cityEntry.Text) || string.IsNullOrWhiteSpace(artistURLEntry.Text))
            {
                await DisplayAlert("Registration", "Please Enter Information.", "OK");
                return;
            }
            else
            {
                string stagename = stageNameEntry.Text;
                string fname = entry_First.Text;
                string lname = entry_Last.Text;
                string street = streetEntry.Text;
                string city = cityEntry.Text;
                string state = State.SelectedItem.ToString();
                string zip = zipEntry.Text;
                string website = artistURLEntry.Text;
                Genre = genre.SelectedItem.ToString();
                string subgenre = subGenre.SelectedItem.ToString();
                string Bio = BioEdt.Text;

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

            if (Genre.Equals("Avant_Garde"))
            {
                subGenre.ItemsSource = Constants.Avant_Garde;
            }
            else if (Genre.Equals("Blues"))
            {
                subGenre.ItemsSource = Constants.Blues;
            }
            else if (Genre.Equals("Children"))
            {
                subGenre.ItemsSource = Constants.Children;
            }
            else if (Genre.Equals("Classical"))
            {
                subGenre.ItemsSource = Constants.Classical;
            }
            else if (Genre.Equals("Comedy"))
            {
                subGenre.ItemsSource = Constants.Comedy;
            }
            else if (Genre.Equals("Country"))
            {
                subGenre.ItemsSource = Constants.Country;
            }
            else if (Genre.Equals("Easy Listening"))
            {
                subGenre.ItemsSource = Constants.Easy_Listening;
            }
            else if (Genre.Equals("Electronic"))
            {
                subGenre.ItemsSource = Constants.Electronic;
            }
            else if (Genre.Equals("Folk"))
            {
                subGenre.ItemsSource = Constants.Folk;
            }
            else if (Genre.Equals("Holiday"))
            {
                subGenre.ItemsSource = Constants.Holiday;
            }
            else if (Genre.Equals("International"))
            {
                subGenre.ItemsSource = Constants.International;
            }
            else if (Genre.Equals("Jazz"))
            {
                subGenre.ItemsSource = Constants.Jazz;
            }
            else if (Genre.Equals("Latin"))
            {
                subGenre.ItemsSource = Constants.Latin;
            }
            else if (Genre.Equals("New Age"))
            {
                subGenre.ItemsSource = Constants.New_Age;
            }
            else if (Genre.Equals("Pop"))
            {
                subGenre.ItemsSource = Constants.Pop;
            }
            else if (Genre.Equals("R&B"))
            {
                subGenre.ItemsSource = Constants.RandB;
            }
            else if (Genre.Equals("Reggae"))
            {
                subGenre.ItemsSource = Constants.Reggae;
            }
            else if (Genre.Equals("Religious"))
            {
                subGenre.ItemsSource = Constants.Religious;
            }
            else if (Genre.Equals("Rock"))
            {
                subGenre.ItemsSource = Constants.Rock;
            }
            else if (Genre.Equals("Spoken"))
            {
                subGenre.ItemsSource = Constants.Spoken;
            }
            else if (Genre.Equals("Stage"))
            {
                subGenre.ItemsSource = Constants.Stage;
            }
            else if (Genre.Equals("Vocal"))
            {
                subGenre.ItemsSource = Constants.Vocal;
            }
        }
    }
}
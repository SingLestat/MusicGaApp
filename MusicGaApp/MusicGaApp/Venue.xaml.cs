using MusicGaApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicGaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Venue : ContentPage
    {
        public Venue()
        {
            InitializeComponent();
        }
        async void Register_Clicked(object sender, EventArgs e)
        {
            if (State.SelectedIndex == -1 || string.IsNullOrWhiteSpace(venueEntry.Text) || string.IsNullOrWhiteSpace(ownerFnameEntry.Text) || string.IsNullOrWhiteSpace(ownerLnameEntry.Text) || string.IsNullOrWhiteSpace(zipEntry.Text) || string.IsNullOrWhiteSpace(cityEntry.Text) || string.IsNullOrWhiteSpace(urlEntry.Text))
            {
                await DisplayAlert("Registration", "Please Enter Information.", "OK");
                return;
            }
            else
            {
                string venueName = venueEntry.Text;
                string fname = ownerFnameEntry.Text;
                string lname = ownerLnameEntry.Text;
                string street = addressEntry.Text;
                string city = cityEntry.Text;
                string state = State.SelectedItem.ToString();
                string zip = zipEntry.Text;
                string website = urlEntry.Text;
                string Bio = BioEdt.Text;

                VenueInfo venueInfo = new VenueInfo()
                {
                    venueName = venueName,
                    firstName = fname,
                    lastName = lname,
                    street = street,
                    city = city,
                    state = state,
                    zipCode = zip,
                    website = website,
                    bio = Bio
                };

                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<VenueInfo>();
                    conn.Insert(venueInfo);
                }

                //DataInput.InputVenue(venueName, fname, lname, street, city, state, zip, website, Bio);

                await DisplayAlert("Registration", "Your Registration will be reviewed.", "OK");
                return;
            }
        }

        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), false);
        }
    }
}
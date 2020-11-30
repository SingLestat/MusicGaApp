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
    public partial class Venue : ContentPage
    {
        public Venue()
        {
            InitializeComponent();

            State.ItemsSource = Constants.States;
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
                string email = emailEntry.Text;
                string phone = phoneEntry.Text;
                string street = addressEntry.Text;
                string city = cityEntry.Text;
                string state = State.SelectedItem.ToString();
                string zip = zipEntry.Text;
                string website = urlEntry.Text;

                DataInput.InputVenue(venueName, fname, lname, email, website, phone, street, city, state, zip);

                await DisplayAlert("Registration", "Your Registration will be reviewed.", "OK");

            }
        }

        private async void Back_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), false);
        }
    }
}
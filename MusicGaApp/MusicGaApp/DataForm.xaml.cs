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
    public partial class DataForm : ContentPage
    {
        public DataForm()
        {
            InitializeComponent();

            State.ItemsSource = Constants.States;
            Industry.ItemsSource = Constants.Industry;
        }
        async void Register_Clicked(object sender, EventArgs e)
        {
            if (State.SelectedIndex == -1 || Industry.SelectedIndex == - 1 || string.IsNullOrWhiteSpace(comapnyEntry.Text) || string.IsNullOrWhiteSpace(ownerFnameEntry.Text) || string.IsNullOrWhiteSpace(ownerLnameEntry.Text) || string.IsNullOrWhiteSpace(addressEntry.Text) || string.IsNullOrWhiteSpace(zipEntry.Text) || string.IsNullOrWhiteSpace(cityEntry.Text) || string.IsNullOrWhiteSpace(urlEntry.Text))
            {
                await DisplayAlert("Registration", "Please Enter Information.", "OK");             
                return;
            }
            else
            {
                string company = comapnyEntry.Text;
                string ownerFname = ownerFnameEntry.Text;
                string ownerLname = ownerLnameEntry.Text;
                string street = addressEntry.Text;
                string city = cityEntry.Text;
                string state = State.SelectedItem.ToString();
                string zip = zipEntry.Text;
                string website = urlEntry.Text;
                string industry = Industry.SelectedItem.ToString();
                string Bio = BioEdt.Text;


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
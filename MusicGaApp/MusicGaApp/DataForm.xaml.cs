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
    public partial class DataForm : ContentPage
    {
        public DataForm()
        {
            InitializeComponent();
        }

        async void Register_Clicked(object sender, EventArgs e)
        {
            if (State.SelectedIndex == -1 || Industry.SelectedIndex == - 1 || string.IsNullOrWhiteSpace(comapnyEntry.Text) || string.IsNullOrWhiteSpace(ownerEntry.Text) || string.IsNullOrWhiteSpace(addressEntry.Text) || string.IsNullOrWhiteSpace(zipEntry.Text) || string.IsNullOrWhiteSpace(cityEntry.Text) || string.IsNullOrWhiteSpace(urlEntry.Text))
            {
                await DisplayAlert("Registration", "Please Enter Information.", "OK");             
                return;
            }
            else
            {
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
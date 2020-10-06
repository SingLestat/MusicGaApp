using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MusicGaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DataForm(), false);
        }

        async void Directorybtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Directory", "Coming Soon!", "OK");
            return;
        }

    }
}

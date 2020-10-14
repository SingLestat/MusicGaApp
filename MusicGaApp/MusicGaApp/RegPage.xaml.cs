using MusicGaApp.ViewModels;
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
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {

        }

        async void RegProcedure(object sender, EventArgs e)
        {
            await DisplayAlert("Registration", "Registration Success", "Ok");
            await Navigation.PushModalAsync(new MainPage(), false);
        }
        async void SkipProcedure(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), false);
        }
    }
}
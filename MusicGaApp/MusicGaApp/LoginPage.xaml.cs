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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            Spinner.IsVisible = false;

            

            entry_Email.Completed += (s, e) => entry_Password.Focus();
            entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }
        async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(entry_Email.Text, entry_Password.Text);
            if(user.checkInfo())
            {
                await DisplayAlert("Login", "Login Success", "Ok");
                await Navigation.PushModalAsync(new MainPage(), false);
            }
            else
            {
                await DisplayAlert("Login", "Login Not Correct", "Ok");
            }
        }

        async void Registerbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegPage(), false);
        }

        async void ForgotPassbtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Password Recovery", "Coming Soon!", "OK");
        }
    }
}
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
        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(entry_Email.Text, entry_Password.Text);
            if(user.checkInfo())
            {
                DisplayAlert("Login", "Login Success", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct", "Ok");
            }
        }
    }
}
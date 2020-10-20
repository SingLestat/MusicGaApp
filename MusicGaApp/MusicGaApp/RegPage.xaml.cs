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
        bool shown = false;
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
            if (!String.IsNullOrWhiteSpace(entry_First.Text) || !String.IsNullOrWhiteSpace(entry_Last.Text) || !String.IsNullOrWhiteSpace(entry_Email.Text) || !String.IsNullOrWhiteSpace(entry_Password.Text))
            {
                string fName = entry_First.Text;
                string lName = entry_Last.Text;
                string email = entry_Email.Text;

                if (entry_Password.Text.Equals(entry_ReEnter.Text))
                {
                    string password = entry_Password.Text;

                    if (password.Length < 8 && password.Any(char.IsUpper) && User.checkSpecialChar(password) && password.Any(char.IsDigit))
                    {

                        if (DataGet.uniqueUser(email))
                        {
                            DataInput.InputUser(fName, lName, email, password);

                            await DisplayAlert("Registration", "Registration Success", "Ok");
                            await Navigation.PushModalAsync(new MainPage(), false);
                        }
                        else
                        {
                            await DisplayAlert("Login", "Account using this email already exist.", "Ok");
                            await Navigation.PushModalAsync(new LoginPage(), false);
                        }
                    }
                    else
                    {
                        await DisplayAlert("Password", "Password do not meet requirements.", "Ok");
                        await Navigation.PushModalAsync(new LoginPage(), false);
                    }
                }
                else
                {
                    await DisplayAlert("Password", "Passwords do not match.", "Ok");
                    await Navigation.PushModalAsync(new RegPage(), false);
                }
            }
            else
            {
                await DisplayAlert("Requirement", "All fields are required.", "Ok");
                await Navigation.PushModalAsync(new LoginPage(), false);
            }
        }
        async void SkipProcedure(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), false);
        }

        private void entry_Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (shown == false)
            {
                DisplayAlert("Password Requirements", "At least 8 characters" + Environment.NewLine +
                                                      "Uppercase and Lowercase letters." + Environment.NewLine +
                                                      "A mixture of letters and numbers." + Environment.NewLine +
                                                      "Inclusion of at least one special character", "ok");
                shown = true;
            }
            else
            {

            }
        }
    }
}
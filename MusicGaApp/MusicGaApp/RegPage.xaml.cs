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
    public partial class RegPage : ContentPage
    {
        private bool dateChanged;

        bool shown = false;
        public RegPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            State.ItemsSource = Constants.States;
        }

        async void RegProcedure(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(entry_First.Text) || !String.IsNullOrWhiteSpace(entry_Last.Text) || !String.IsNullOrWhiteSpace(entry_Email.Text) || !String.IsNullOrWhiteSpace(entry_Password.Text) || dateChanged == true || !String.IsNullOrWhiteSpace(entry_Phone.Text) || !String.IsNullOrWhiteSpace(addressEntry.Text) || !String.IsNullOrWhiteSpace(cityEntry.Text))
            {
                Random random = new Random();

                string fName = entry_First.Text;
                string lName = entry_Last.Text;
                string gender = Gender.SelectedItem.ToString();
                string phone = entry_Phone.Text;
                string address = addressEntry.Text;
                string city = cityEntry.Text;
                string state = State.SelectedItem.ToString();
                string zip = zipEntry.Text;
                DateTime date = DateOfBirth.Date;
                string photoUrl = "none";
                string email = entry_Email.Text;

                if (DataGet.IsValidEmail(email))
                {
                    if (DataGet.uniqueUser(email))
                    {
                        if (entry_Password.Text.Equals(entry_ReEnter.Text))
                        {
                            string password = entry_Password.Text;

                            if (password.Length >= 8 )
                                //&& password.Contains(Constants.specialChar) && password.Any(char.IsUpper) && password.Any(char.IsLower) && !password.Any(char.IsWhiteSpace)
                            {

                                if (DataGet.uniqueUser(email))
                                {
                                    DataInput.InputUser(fName, lName, email.ToLower(), password, gender, String.Format("{0:###-###-####}", double.Parse(phone)), address, city, state, zip, date, photoUrl);

                                    await DisplayAlert("Registration", "Registration Success", "Ok");
                                    await Navigation.PushModalAsync(new LoginPage(), false);
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
                        await DisplayAlert("Account", "Account already exist.", "Ok");
                        await Navigation.PushModalAsync(new LoginPage(), false);
                    }
                }
                else
                {
                    await DisplayAlert("Email", "Email is not a valid email.", "Ok");
                    await Navigation.PushModalAsync(new RegPage(), false);
                }
            }
            else
            {
                await DisplayAlert("Requirement", "All fields are required.", "Ok");
                await Navigation.PushModalAsync(new RegPage(), false);
            }
        }

        private void entry_Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (shown == false)
            {
                //DisplayAlert("Password Requirements", "At least 8 characters" + Environment.NewLine + "Uppercase and Lowercase letters." + Environment.NewLine + "A mixture of letters and numbers." + Environment.NewLine + "Inclusion of at least one special character", "ok");
                shown = true;
            }
            else
            {

            }
        }

        private void eventDate_BindingContextChanged(object sender, EventArgs e)
        {
            dateChanged = true;
        }

    }
}
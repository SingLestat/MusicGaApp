﻿using MusicGaApp.ViewModels;
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
    public partial class Events : ContentPage
    {
        private bool dataChanged;
        private bool timeChanged;

        public Events()
        {
            InitializeComponent();
        }

        async void Register_Clicked(object sender, EventArgs e)
        {
            if (State.SelectedIndex == -1 || string.IsNullOrWhiteSpace(eventEntry.Text) || string.IsNullOrWhiteSpace(ownerFnameEntry.Text) || string.IsNullOrWhiteSpace(ownerLnameEntry.Text) || string.IsNullOrWhiteSpace(zipEntry.Text) || string.IsNullOrWhiteSpace(cityEntry.Text) || string.IsNullOrWhiteSpace(urlEntry.Text) || dataChanged == true || timeChanged == true)
            {
                await DisplayAlert("Registration", "Please Enter Information.", "OK");
                return;
            }
            else
            {
                string eventName = eventEntry.Text;
                string fname = ownerFnameEntry.Text;
                string lname = ownerLnameEntry.Text;
                string street = addressEntry.Text;
                string city = cityEntry.Text;
                string state = State.SelectedItem.ToString();
                string zip = zipEntry.Text;
                string website = urlEntry.Text;
                string date = eventData.Date.ToString();
                string time = eentTime.Time.ToString();
                string Bio = BioEdt.Text;

            }
        }

        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), false);
        }

        private void eventData_BindingContextChanged(object sender, EventArgs e)
        {
            dataChanged = true;
        }

        private void eentTime_BindingContextChanged(object sender, EventArgs e)
        {
            timeChanged = true;
        }
    }
}
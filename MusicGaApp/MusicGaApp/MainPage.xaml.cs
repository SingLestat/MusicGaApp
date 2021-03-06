﻿using System;
using Xamarin.Forms;

namespace MusicGaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void VenueButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Venue(), false);
        }

        async void ArtistButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Artist(), false);
        }

        async void Directorybtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Directory(), false);
        }

    }
}

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicGaApp
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new LoginPage();

            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        { 
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

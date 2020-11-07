using MusicGaApp.ViewModels;
using MySqlConnector;
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
    public partial class Directory : ContentPage
    {
        private string TableName = "";
        private string ColName = "";

        public Directory()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var seletedItem = listView.SelectedItem.ToString();

            if(seletedItem != null)
            {
                Navigation.PushModalAsync(new ItemDetail(seletedItem, TableName, ColName), false);
            }
        }

        private void SelectBtn_Clicked(object sender, EventArgs e)
        {

            if(entryType.SelectedItem.ToString().Equals("Artist"))
            {
                TableName = "Artist";
                ColName = "ARTIST_NAME";
            }
            else if(entryType.SelectedItem.ToString().Equals("Event"))
            {
                TableName = "Event";
                ColName = "EVENT_TITLE";
            }
            else if(entryType.SelectedItem.ToString().Equals("Company"))
            {
                TableName = "Company";
                ColName = "COMPANY_NAME";
            }
            else if(entryType.SelectedItem.ToString().Equals("Venue"))
            {
                TableName = "Venue";
                ColName = "VENUE_NAME";
            }
            else
            {
                DisplayAlert("Select Entry Type","Please select the type of entry you want.","Ok");
                return;

            }

            listView.ItemsSource = DataGet.GetDatabaseList(ColName, TableName);
        }
    }
}
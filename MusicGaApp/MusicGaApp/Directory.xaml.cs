using MusicGaApp.Model;
using SQLite;
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
    public partial class Directory : ContentPage
    {
        public Directory()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<ArtistInfo>();

                var artistList = conn.Table<ArtistInfo>().ToList();

                listView.ItemsSource = artistList;
            }
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var seletedItem = listView.SelectedItem as ArtistInfo;

            if(seletedItem != null)
            {
                Navigation.PushModalAsync(new ItemDetail(seletedItem), false);
            }
        }
    }
}
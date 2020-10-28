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
    public partial class ItemDetail : ContentPage
    {
        ArtistInfo selectedItem;
        public ItemDetail(ArtistInfo selectedItem)
        {
            InitializeComponent();

            this.selectedItem = selectedItem;

            Title.Text += selectedItem.stageName;
            artistStageName.Text += selectedItem.stageName;
            artistFirstName.Text += selectedItem.firstName;
            artistLastName.Text += selectedItem.lastName;
            artistStreet.Text += selectedItem.street;
            artistCity.Text += selectedItem.city;
            artistState.Text += selectedItem.state;
            artistZip.Text += selectedItem.zipCode;
            artistWebsite.Text += selectedItem.website;
            artistGenre.Text += selectedItem.genre;
            artistSubGenre.Text += selectedItem.subgenre;
            artistBio.Text += selectedItem.bio;
        }
    }
}
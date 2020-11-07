using MusicGaApp.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public ItemDetail(string selectedItem, string Table, string ColName)
        {
            InitializeComponent();

            ItemEntryView.ItemsSource = DataGet.GetDatabaseList(selectedItem,Table,ColName);
        }
    }
}
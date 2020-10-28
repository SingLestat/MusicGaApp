using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGaApp.Model
{
    public class ArtistInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string stageName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string website { get; set; }
        public string genre { get; set; }
        public string subgenre { get; set; }
        public string bio { get; set; }
    }
}

﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGaApp.Model
{
    class VenueInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string venueName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string website { get; set; }
        public string bio { get; set; }
    }
}

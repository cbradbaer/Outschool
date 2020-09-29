using System;
using System.Collections.Generic;
using System.Text;

namespace VinylVaultApp.Model
{
    public class AlbumModel
    {

        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string ThumbImage { get; set; }
        public string Location { get; set; }

        public AlbumModel(string _title, string _artist, string _genre, string _thumbimage, string _location)
        {
            Title = _title;
            Artist = _artist;
            Genre = _genre;
            ThumbImage = _thumbimage;
            Location = _location;

        }
    }
}

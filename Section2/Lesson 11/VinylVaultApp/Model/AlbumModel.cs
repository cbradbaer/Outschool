using System;
using System.Collections.Generic;
using System.Text;

namespace VinylVaultApp.Model
{
    public class AlbumModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Location { get; set; }

        public string ThumbImage { get; set; }
        public string Genre { get; set; }

        public AlbumModel(string _Title, string _Artist, string _Location, string _ThumbImage, string _Genre)
        {
            Title = _Title;
            Artist = _Artist;
            Location = _Location;
            ThumbImage = _ThumbImage;
            Genre = _Genre;
        }

        public AlbumModel()
        {


        }

    }
}

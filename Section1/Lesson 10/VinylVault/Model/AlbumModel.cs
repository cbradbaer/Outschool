using System;
using System.Collections.Generic;
using System.Text;

namespace VinylVault.Model
{
    public class AlbumModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string ThumbImage { get; set; }
        public string Location { get; set; }


        public AlbumModel(string _Title, string _Artist, string _Genre, string _ThumbImage, string _Location)
        {
            Title = _Title;
            Artist = _Artist;
            Genre = _Genre;
            ThumbImage = _ThumbImage;
            Location = _Location;
        }



    }
}

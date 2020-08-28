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
        public string Location { get; set; }
        public string ThumbImage { get; set; }
        public bool IsPlayable { get; set; }

        public AlbumModel(string _Title, string _Artist, string _Genre, string _Location, string _ThumbImage)
        {
            Title = _Title;
            Artist = _Artist;
            Genre = _Genre;
            Location = _Location;
            ThumbImage = _ThumbImage;

        }



    }
}

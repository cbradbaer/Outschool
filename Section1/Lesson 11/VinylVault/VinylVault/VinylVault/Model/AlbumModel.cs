using System;
using System.Collections.Generic;
using System.Text;

namespace VinylVault.Model
{
   public class AlbumModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Location { get; set; }
        public string FrontImage { get; set; }
        public string Genre { get; set; }

        public AlbumModel(string _Title, string _Artist, string _Location, string _FrontImage, string _Genre)
        {
            Title = _Title;
            Artist = _Artist;
            Location = _Location;
            FrontImage = _FrontImage;
            Genre = _Genre;
        }

        public AlbumModel()
        {

        }


    }
}

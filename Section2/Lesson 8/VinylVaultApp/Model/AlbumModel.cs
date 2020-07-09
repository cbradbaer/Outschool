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

        public AlbumModel(string _Title, string _Artist, string _Location)
        {
            Title = _Title;
            Artist = _Artist;
            Location = _Artist;
        }

    }
}

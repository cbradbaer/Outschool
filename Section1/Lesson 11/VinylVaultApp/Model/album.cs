using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VinylVaultApp.Model
{
    public class album
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Location { get; set; }
        public string ThumbImage { get; set; }
        public string Genre { get; set; }
        public int NumberOfDiscs { get; set; }
        public string Price { get; set; }




        public album(string _Title, string _Artist, string _Location, string _ThumbImage, string _Genre, int _NumberOfDiscs, string _Price)
        {
            Title = _Title;
            Artist = _Artist;
            Location = _Location;
            ThumbImage = _ThumbImage;
            Genre = _Genre;
            NumberOfDiscs = _NumberOfDiscs;
            Price = _Price;
        }

        public album()
        {


        }


    }
}

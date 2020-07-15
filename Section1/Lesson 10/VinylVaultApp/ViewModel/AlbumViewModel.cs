using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using VinylVaultApp.Model;

namespace VinylVaultApp.ViewModel
{
    public class AlbumViewModel : INotifyPropertyChanged
    {
        public album SelectedAlbum;
        private string _CollectionName;
        public string CollectionName
        {
            get
            {
                return _CollectionName;
            }
            set
            {
                _CollectionName = value;
                RaisePropertyChanged("CollectionName");
            }
        }

        public List<album> albumList;

        public async Task<bool> GetCollection()
        {
            if (albumList == null)
            {
                albumList = new List<album>();
                albumList.Add(new album("The Doors", "The Doors", "Box 1", "Album1.jpg", "Rock"));
                albumList.Add(new album("Escape", "Journey", "Box 2", "Album3.jpg", "Rock"));
                albumList.Add(new album("Volunteers", "Jefferson Airplane", "Box 3", "Album2.jpg", "Rock"));
            }

            return true;


        }

        public bool DeleteAlbum(album alb)
        {
            albumList.Remove(alb);
            return true;

        }

        public bool InsertAlbum(album alb)
        {
            albumList.Add(alb);
            return true;

        }

        public bool UpdateAlbum(album alb)
        {
            SelectedAlbum.Title = alb.Title;
            SelectedAlbum.Artist = alb.Artist;
            SelectedAlbum.Location = alb.Location;
            SelectedAlbum.ThumbImage = alb.ThumbImage;
            SelectedAlbum.Genre = alb.Genre;
            return true;
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }




    }
}

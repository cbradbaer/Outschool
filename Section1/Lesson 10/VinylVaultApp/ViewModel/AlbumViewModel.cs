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
        private string _CollectionName;
        public List<AlbumModel> albumList;
        public AlbumModel selectedAlbum;

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


        public async Task<bool> GetAlbums()
        {
            if (albumList == null)
            {
                albumList = new List<AlbumModel>();
                albumList.Add(new AlbumModel("LA Woman", "The Doors", "Rock", "https://picsum.photos/200", "Box 1"));
                albumList.Add(new AlbumModel("Escape", "Journey", "Rock", "https://picsum.photos/201", "Box 2"));
                albumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "https://picsum.photos/202", "Box 3"));
            }

            return true;


        }

        public async Task<bool> DeleteAlbum(AlbumModel alb)
        {

            albumList.Remove(alb);
            return true;

        }

        public async Task<bool> InsertAlbum(AlbumModel alb)
        {

            albumList.Add(alb);
            return true;

        }

        public async Task<bool> UpdateAlbum(AlbumModel alb)
        {

            selectedAlbum.Title = alb.Title;
            selectedAlbum.Artist = alb.Artist;
            selectedAlbum.Genre = alb.Genre;
            selectedAlbum.Location = alb.Location;
            selectedAlbum.ThumbImage = alb.ThumbImage;

            return true;

        }






        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

    }
}

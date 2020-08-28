using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using VinylVault.Model;
using Xamarin.Forms;

namespace VinylVault.ViewModel
{
    public class AlbumViewModel : INotifyPropertyChanged
    {
        public List<AlbumModel> albumList;
        public AlbumModel selectedAlbum;




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


        public async Task<bool> GetAlbums()
        {
            if (albumList == null)
            {
                albumList = new List<AlbumModel>();
                albumList.Add(new AlbumModel("Escape", "Journey", "Rock", "Box1", "https://picsum.photos/300"));
                albumList.Add(new AlbumModel("Exit", "Rush", "Rock", "Box2", "https://picsum.photos/301")); 
                albumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "Box1", "https://picsum.photos/302"));
                albumList.Add(new AlbumModel("Escape", "Journey", "Rock", "Box1", "https://picsum.photos/300"));
                albumList.Add(new AlbumModel("Exit", "Rush", "Rock", "Box2", "https://picsum.photos/301"));
                albumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "Box1", "https://picsum.photos/302"));
                albumList.Add(new AlbumModel("Escape", "Journey", "Rock", "Box1", "https://picsum.photos/300"));
                albumList.Add(new AlbumModel("Exit", "Rush", "Rock", "Box2", "https://picsum.photos/301"));
                albumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "Box1", "https://picsum.photos/302"));
                albumList.Add(new AlbumModel("Escape", "Journey", "Rock", "Box1", "https://picsum.photos/300"));
                albumList.Add(new AlbumModel("Exit", "Rush", "Rock", "Box2", "https://picsum.photos/301"));
                albumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "Box1", "https://picsum.photos/302"));
            }

            return true;

        }


        public bool DeleteAlbum(AlbumModel alb)
        {
            albumList.Remove(alb);
            return true;

        }


        public bool InsertAlbum(AlbumModel alb)
        {
            albumList.Add(alb);
            return true;

        }

        public bool UpdateAlbum(AlbumModel alb)
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

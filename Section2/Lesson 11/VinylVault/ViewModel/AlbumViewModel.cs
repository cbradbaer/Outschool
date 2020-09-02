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

            albumList = await App.Database.GetAlbumsAsync();

            if (albumList.Count == 0)
            {
                albumList = new List<AlbumModel>();
                await App.Database.InsertAlbum(new AlbumModel("The Doors", "The Doors", "Rock", "Box 1", "https://picsum.photos/300"));
                await App.Database.InsertAlbum(new AlbumModel("Volunteers", "Jefferson Airplane", "Rock", "Box 1", "https://picsum.photos/310"));
                await App.Database.InsertAlbum(new AlbumModel("Escape", "Journey", "Rock", "Box 2", "https://picsum.photos/302"));
                await App.Database.InsertAlbum(new AlbumModel("Exit", "Tangerine Dream", "Electronic", "Box 2", "https://picsum.photos/303"));
                await App.Database.InsertAlbum(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "Box 2", "https://picsum.photos/304"));
                await App.Database.InsertAlbum(new AlbumModel("LA Woman", "The Doors", "Rock", "Box 1", "https://picsum.photos/305"));
                await App.Database.InsertAlbum(new AlbumModel("Moving Pictures", "Rush", "Rock", "Box 2", "https://picsum.photos/306"));
            }

            return true;

        }


        public async Task<bool> DeleteAlbum(AlbumModel alb)
        {
            //albumList.Remove(alb);

            await App.Database.DeleteAlbum(alb);
            return true;

        }


        public async Task<bool> InsertAlbum(AlbumModel alb)
        {
            //albumList.Add(alb);
            await App.Database.InsertAlbum(alb);
            return true;

        }

        public async Task<bool> UpdateAlbum(AlbumModel alb)
        {
            //selectedAlbum.Title = alb.Title;
            //selectedAlbum.Artist = alb.Artist;
            //selectedAlbum.Genre = alb.Genre;
            //selectedAlbum.Location = alb.Location;
            //selectedAlbum.ThumbImage = alb.ThumbImage;

            await App.Database.UpdateAlbum(alb);
            return true;

        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }





    }
}

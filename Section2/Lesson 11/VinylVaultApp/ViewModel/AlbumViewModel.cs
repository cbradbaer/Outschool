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
        public AlbumModel SelectedAlbum;
        public List<AlbumModel> albumList;

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


            if (albumList == null  || albumList.Count == 0)
            {
                albumList = new List<AlbumModel>();
                await App.Database.InsertAlbum(new AlbumModel("Volunteers", "Jefferson Airplane", "Box 1","album1.jpg","Rock"));
                await App.Database.InsertAlbum(new AlbumModel("LA Woman", "The Doors", "Box 2", "album6.jpg", "Rock"));
                await App.Database.InsertAlbum(new AlbumModel("Escape", "Journey", "Box 3", "album3.jpg", "Rock"));

                await GetAlbums();


            }

            return true;
        
        }


        public async Task<bool> InsertAlbum(AlbumModel alb)
        {
            await App.Database.InsertAlbum(alb);
            
         //   albumList.Add(alb);
            return true;

        }

        public async Task<bool> DeleteAlbum(AlbumModel alb)
        {
            await App.Database.DeleteAlbum(alb);

           // albumList.Remove(alb);
            return true;

        }

        public async Task<bool> UpdateAlbum(AlbumModel alb)
        {
            await App.Database.UpdateAlbum(alb);

            //SelectedAlbum.Title = alb.Title;
            //SelectedAlbum.Artist = alb.Artist;
            //SelectedAlbum.Location = alb.Location;
            //SelectedAlbum.ThumbImage = alb.ThumbImage;
            //SelectedAlbum.Genre = alb.Genre;
            
            return true;

        }















        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }





    }
}

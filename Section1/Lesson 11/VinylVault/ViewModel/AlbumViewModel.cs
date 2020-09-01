using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using VinylVault.Model;

namespace VinylVault.ViewModel
{
    public class AlbumViewModel : INotifyPropertyChanged
    {
        public AlbumModel SelectedAlbum;
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

        public List<AlbumModel> AlbumList;


        public async Task<bool> GetAlbums()
        {

            AlbumList = await App.Database.GetAlbumsAsync();

            if (AlbumList.Count == 0)
            {
                AlbumList = new List<AlbumModel>();
                await App.Database.InsertAlbum(new AlbumModel("Escape", "Journey", "Rock", "https://picsum.photos/300", "Box 1"));
                await App.Database.InsertAlbum(new AlbumModel("Exit", "Rush", "Rock", "https://picsum.photos/200", "Box 2"));
                await App.Database.InsertAlbum(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "https://picsum.photos/100", "Box 3"));
                await App.Database.InsertAlbum(new AlbumModel("Escape", "Journey", "Rock", "https://picsum.photos/300", "Box 1"));
                await App.Database.InsertAlbum(new AlbumModel("Exit", "Rush", "Rock", "https://picsum.photos/200", "Box 2"));
                await App.Database.InsertAlbum(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "https://picsum.photos/100", "Box 3"));
                await App.Database.InsertAlbum(new AlbumModel("Escape", "Journey", "Rock", "https://picsum.photos/300", "Box 1"));
                await App.Database.InsertAlbum(new AlbumModel("Exit", "Rush", "Rock", "https://picsum.photos/200", "Box 2"));
                await App.Database.InsertAlbum(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "https://picsum.photos/100", "Box 3"));
                await App.Database.InsertAlbum(new AlbumModel("Escape", "Journey", "Rock", "https://picsum.photos/300", "Box 1"));
                await App.Database.InsertAlbum(new AlbumModel("Exit", "Rush", "Rock", "https://picsum.photos/200", "Box 2"));
                await App.Database.InsertAlbum(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "https://picsum.photos/100", "Box 3"));
            }

            return true;


        }

        public async Task<bool> DeleteAlbum(AlbumModel alb)
        {
            await App.Database.DeleteAlbum(alb);
            return true;
        }


        public async Task<bool> InsertAlbum(AlbumModel alb)
        {

            await App.Database.InsertAlbum(alb);
            return true;

        }


        public async Task<bool> UpdateAlbum(AlbumModel alb)
        {


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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VinylVault.Model;

namespace VinylVault.ViewModel
{
    public class AlbumViewModel : INotifyPropertyChanged
    {
        private string _CollectionName;
        public List<AlbumModel> AlbumList;
        private AlbumModel _SelectedAlbum; 

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


        public AlbumModel SelectedAlbum
        {
            get
            {
                return _SelectedAlbum;
            }

            set
            {
                _SelectedAlbum = value;
                RaisePropertyChanged("SelectedAlbum");
            }

        }




        public async Task<bool> GetAlbums()
        {
            AlbumList = await App.Database.GetAlbumsAsync();
            if (AlbumList == null  || AlbumList.Count == 0)
            {
                
                await App.Database.InsertAlbum(new AlbumModel("The Doors", "The Doors", "Box 1", "https://picsum.photos/100", "Rock"));
                await App.Database.InsertAlbum(new AlbumModel("Volunteers", "Jefferson Airplane", "Box 2", "https://picsum.photos/101", "Rock"));
                await App.Database.InsertAlbum(new AlbumModel("Exit", "Tangerine Dream", "Box 1", "https://picsum.photos/102", "Electronic"));
                await App.Database.InsertAlbum(new AlbumModel("LA Woman", "The Doors", "Box 3", "https://picsum.photos/103", "Rock"));
                await App.Database.InsertAlbum(new AlbumModel("Moving Pictures", "Rush", "Box 1", "https://picsum.photos/104", "Heavy Metal"));

                AlbumList = await App.Database.GetAlbumsAsync();

                //AlbumList = new List<AlbumModel>();
                //AlbumList.Add(new AlbumModel("The Doors", "The Doors", "Box 1", "https://picsum.photos/100", "Rock"));
                //AlbumList.Add(new AlbumModel("Volunteers", "Jefferson Airplane", "Box 2", "https://picsum.photos/101", "Rock"));
                //AlbumList.Add(new AlbumModel("Exit", "Tangerine Dream", "Box 1", "https://picsum.photos/102", "Electronic"));
                //AlbumList.Add(new AlbumModel("LA Woman", "The Doors", "Box 3", "https://picsum.photos/103", "Rock"));
                //AlbumList.Add(new AlbumModel("Moving Pictures", "Rush", "Box 1", "https://picsum.photos/104", "Heavy Metal"));
            }

           

            return true;
        }


        public async Task<bool> DeleteAlbum(AlbumModel alb)
        {
            // AlbumList.Remove(alb);

            await App.Database.DeleteAlbum(alb);
            return true;
        }


        public async Task<bool> InsertAlbum(AlbumModel alb)
        {

            //AlbumList.Add(alb);

            await App.Database.InsertAlbum(alb);
            return true;
        }


        public async Task<bool> UpdateAlbum(AlbumModel alb)
        {

            await App.Database.UpdateAlbum(alb);



            //SelectedAlbum.Title = alb.Title;
            //SelectedAlbum.Artist = alb.Artist;
            //SelectedAlbum.Location = alb.Location;
            //SelectedAlbum.FrontImage = alb.FrontImage;
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

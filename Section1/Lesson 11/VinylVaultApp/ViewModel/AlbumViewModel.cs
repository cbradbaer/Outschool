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

        private string _NumDiscs;
        public string NumDiscs
        {
            get
            {
                return _NumDiscs;
            }
            set
            {
                _NumDiscs = value;
                RaisePropertyChanged("NumDiscs");
            }
        }



        public List<album> albumList;

        public async Task<bool> GetCollection()
        {

            albumList = await App.Database.GetAlbumsAsync();



            if (albumList == null || albumList.Count == 0 )
            {
                albumList = new List<album>();
                await App.Database.InsertAlbum(new album("The Doors", "The Doors", "Box 1", "album1.jpg", "Rock", 1, "4.25"));
                await App.Database.InsertAlbum(new album("Escape", "Journey", "Box 2", "album3.jpg", "Rock", 2, "10.50"));
                await App.Database.InsertAlbum(new album("Volunteers", "Jefferson Airplane", "Box 3", "album2.jpg", "Rock", 3, "10.00"));

                await GetCollection();

                //albumList.Add(new album("The Doors", "The Doors", "Box 1", "album1.jpg", "Rock", 1, "4.25"));
                //albumList.Add(new album("Escape", "Journey", "Box 2", "album3.jpg", "Rock", 2, "10.50"));
                //albumList.Add(new album("Volunteers", "Jefferson Airplane", "Box 3", "album2.jpg", "Rock", 3, "10.00"));


            }

            return true;


        }

        public async Task<bool> DeleteAlbum(album alb)
        {
            await App.Database.DeleteAlbum(alb);

            //albumList.Remove(alb);
            return true;

        }

        public async Task<bool> InsertAlbum(album alb)
        {

            await App.Database.InsertAlbum(alb);

            //albumList.Add(alb);
            return true;

        }

        public async Task<bool> UpdateAlbum(album alb)
        {
            await App.Database.UpdateAlbum(alb);

            //SelectedAlbum.Title = alb.Title;
            //SelectedAlbum.Artist = alb.Artist;
            //SelectedAlbum.Location = alb.Location;
            //SelectedAlbum.ThumbImage = alb.ThumbImage;
            //SelectedAlbum.Genre = alb.Genre;
            //SelectedAlbum.NumberOfDiscs = alb.NumberOfDiscs;
            //SelectedAlbum.Price = alb.Price;
            return true;
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }




    }
}

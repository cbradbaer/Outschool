using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using VinylVault.Model;

namespace VinylVault.ViewModel
{
    class AlbumViewModel : INotifyPropertyChanged
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
                albumList.Add(new AlbumModel("Escape", "Journey", "Rock", "Box1", ""));
                albumList.Add(new AlbumModel("Exit", "Rush", "Rock", "Box2", "")); 
                albumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "Box1", ""));
            }

            return true;

        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }





    }
}

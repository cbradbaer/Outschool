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
                albumList.Add(new AlbumModel("LA Woman", "The Doors", "Rock", "", "Box 1"));
                albumList.Add(new AlbumModel("Escape", "Journey", "Rock", "", "Box 2"));
                albumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "", "Box 3"));
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using VinylVaultApp.Model;

namespace VinylVaultApp.ViewModel
{
    class AlbumViewModel : INotifyPropertyChanged
    {
        private string _CollectionName;
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
            if (albumList == null)
            {
                albumList = new List<AlbumModel>();
                albumList.Add(new AlbumModel("Volunteers", "Jefferson Airplane", "Box 1","album1.jpg","Rock"));
                albumList.Add(new AlbumModel("LA Woman", "The Doors", "Box 2", "album6.jpg", "Rock"));
                albumList.Add(new AlbumModel("Escape", "Journey", "Box 3", "album3.jpg", "Rock"));
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

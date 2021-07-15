using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using VinylVault.Model;

namespace VinylVault.ViewModel
{
    public class AlbumViewModel : INotifyPropertyChanged
    {
        private string _CollectionName;
        public List<AlbumModel> AlbumList;

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

        public bool GetAlbums()
        {
            if(AlbumList == null)
            {
                AlbumList = new List<AlbumModel>();
                AlbumList.Add(new AlbumModel("The Doors", "The Doors", "Box 1", "https://picsum.photos/100", "Rock"));
                AlbumList.Add(new AlbumModel("Volunteers", "Jefferson Airplane", "Box 2", "https://picsum.photos/101", "Rock"));
                AlbumList.Add(new AlbumModel("Exit", "Tangerine Dream", "Box 1", "https://picsum.photos/102", "Electronic"));
                AlbumList.Add(new AlbumModel("LA Woman", "The Doors", "Box 3", "https://picsum.photos/103", "Rock"));
                AlbumList.Add(new AlbumModel("Moving Pictures", "Rush", "Box 1", "https://picsum.photos/104", "Heavy Metal"));
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

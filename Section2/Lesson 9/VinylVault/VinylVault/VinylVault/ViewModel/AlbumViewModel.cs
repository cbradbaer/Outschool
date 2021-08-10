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


        public List<Album> AlbumList;


        public bool GetAlbums()
        {
            if(AlbumList == null)
            {
                AlbumList = new List<Album>();
                AlbumList.Add(new Album("The Doors", "The Doors", "Box 1", "", "Rock"));
                AlbumList.Add(new Album("Volunteers", "Jefferson Airplane", "Box 1", "", "Rock"));
                AlbumList.Add(new Album("Escape", "Journey", "Box 2", "", "Rock"));
                AlbumList.Add(new Album("Exit", "Tangerine Dream", "Box 2", "", "Electronic"));
                AlbumList.Add(new Album("Rumors", "Fleetwood Mac", "Box 2", "", "Rock"));
                AlbumList.Add(new Album("LA Woman", "The Doors", "Box 1", "", "Rock"));
                AlbumList.Add(new Album("Moving Pictures", "Rush", "Box 2", "", "Rock"));
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

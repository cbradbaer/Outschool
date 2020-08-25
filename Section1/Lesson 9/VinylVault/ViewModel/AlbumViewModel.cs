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
            if (AlbumList == null)
            {
                AlbumList = new List<AlbumModel>();
                AlbumList.Add(new AlbumModel("Escape", "Journey", "Rock", "https://picsum.photos/300", "Box 1"));
                AlbumList.Add(new AlbumModel("Exit", "Rush", "Rock", "https://picsum.photos/200", "Box 2"));
                AlbumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Rock", "https://picsum.photos/100", "Box 3"));
            }

            return true;


        }

        public bool DeleteAlbum(AlbumModel alb)
        {
            AlbumList.Remove(alb);
            return true;
        }





        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }


    }
}

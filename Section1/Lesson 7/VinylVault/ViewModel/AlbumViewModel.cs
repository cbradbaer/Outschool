using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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



        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }


    }
}

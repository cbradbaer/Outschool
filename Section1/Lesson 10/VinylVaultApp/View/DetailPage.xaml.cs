using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVaultApp.Model;
using VinylVaultApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinylVaultApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        album alb;
        AlbumViewModel avm;
        bool isNew;

        public DetailPage(AlbumViewModel _avm, bool _isNew)
        {
            InitializeComponent();

            alb = new album("", "", "", "", "");
            avm = _avm;
            isNew = _isNew;

            if (isNew)
            {

            }
            else
            {
                alb.Title = avm.SelectedAlbum.Title;
                alb.Artist = avm.SelectedAlbum.Artist;
                alb.Genre = avm.SelectedAlbum.Genre;
                alb.Location = avm.SelectedAlbum.Location;
                alb.ThumbImage = avm.SelectedAlbum.ThumbImage;

            }


            BindingContext = alb;

        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void btnOK_Clicked(object sender, EventArgs e)
        {

            if (isNew)
            {
                avm.InsertAlbum(alb);
            }
            else
            {
                avm.UpdateAlbum(alb);
            }
            await Navigation.PopModalAsync();
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVault.Model;
using VinylVault.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinylVault.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        AlbumModel alb;
        AlbumViewModel avm;
        bool isNew;

        public DetailPage(AlbumViewModel _avm, bool _isNew)
        {
            InitializeComponent();
            avm = _avm;
            isNew = _isNew;

            alb = new AlbumModel("", "", "", "", "");

            if(isNew == false)
            {
                alb.Title = avm.selectedAlbum.Title;
                alb.Artist = avm.selectedAlbum.Artist;
                alb.Genre = avm.selectedAlbum.Genre;
                alb.ThumbImage = avm.selectedAlbum.ThumbImage;
                alb.Location = avm.selectedAlbum.Location;
            }

            BindingContext = alb;


        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void btnOK_Clicked(object sender, EventArgs e)
        {
            if(isNew)
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
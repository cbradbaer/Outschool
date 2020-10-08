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

        AlbumModel alb;
        AlbumViewModel avm;
        bool isNew;

        public DetailPage(AlbumViewModel _avm, bool _isNew)
        {
            InitializeComponent();
            avm = _avm;
            isNew = _isNew;

            alb = new AlbumModel("", "", "", "", "");

            if(!isNew)
            {
                alb.Title = avm.selectedAlbum.Title;
                alb.Artist = avm.selectedAlbum.Artist;
                alb.Genre = avm.selectedAlbum.Genre;
                alb.Location = avm.selectedAlbum.Location;
                alb.ThumbImage = avm.selectedAlbum.ThumbImage;
            }

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
             BindingContext = alb;

        }

        private async void btnOK_Clicked(object sender, EventArgs e)
        {
            if (isNew)
                await avm.InsertAlbum(alb);
            else
                await avm.UpdateAlbum(alb);

            await Navigation.PopModalAsync();
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
    }
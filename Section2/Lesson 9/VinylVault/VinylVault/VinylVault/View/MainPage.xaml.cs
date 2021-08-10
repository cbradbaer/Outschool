
using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVault.ViewModel;
using Xamarin.Forms;

namespace VinylVault
{
    public partial class MainPage : ContentPage
    {

        AlbumViewModel avm;

        public MainPage()
        {
            InitializeComponent();
            avm = new AlbumViewModel();
            BindingContext = avm;
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            avm.CollectionName = "Cary's Rock Collection";
            listview.ItemsSource = null;

            avm.GetAlbums();
            listview.ItemsSource = avm.AlbumList;
        }

        private async void btnCollectionName_Clicked(object sender, EventArgs e)
        {
            PromptConfig pg = new PromptConfig();
            pg.Title = "Collection Name";
            pg.Message = "Choose a Collection Name";

            var result = await UserDialogs.Instance.PromptAsync(pg);

            if(result.Ok == true && result.Text != "")
            {

                avm.CollectionName = result.Text;
            }

        }
    }
}

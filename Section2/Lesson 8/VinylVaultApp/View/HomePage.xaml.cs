using Acr.UserDialogs;
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
    public partial class HomePage : ContentPage
    {

        AlbumViewModel avm;
        List<AlbumModel> albumList;

        public HomePage()
        {
            InitializeComponent();
            avm = new AlbumViewModel();
            BindingContext = avm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await avm.GetAlbums();
            albumList = avm.albumList;
            avm.CollectionName = "Carys Rock Collection";
            listView.ItemsSource = albumList;

        }




        private async void btnName_Clicked(object sender, EventArgs e)
        {
            PromptConfig prompt = new PromptConfig();
            prompt.Title = "Collection Name";
            prompt.Message = "Choose a Collection Name";

            var result = await UserDialogs.Instance.PromptAsync(prompt);

            if (result.Ok && result.Text != "")
            {
                avm.CollectionName = result.Text;

            }



        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem != null)
            {
                AlbumModel alb = (AlbumModel)e.SelectedItem;

               await DisplayAlert(alb.Title, alb.Artist, "OK");

            }


        }
    }
}
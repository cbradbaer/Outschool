using Acr.UserDialogs;
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

            avm.CollectionName = "Cary's Classic Collection";
            await RefreshListView();

        }


        public async Task<bool> RefreshListView()
        {
            listView.ItemsSource = null;
            await avm.GetAlbums();
            albumList = avm.AlbumList;
            listView.ItemsSource = albumList;
            return true;
        }



        private async void Button_Clicked(object sender, EventArgs e)
        {
            PromptConfig pc = new PromptConfig();
            pc.Title = "Collection Name";
            pc.Message = "Choose a Collection Name";

            var result = await UserDialogs.Instance.PromptAsync(pc);

            if(result.Ok && result.Text != "")
            {

                avm.CollectionName = result.Text;
            }

            

        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                avm.SelectedAlbum = (AlbumModel)e.SelectedItem;
                await DisplayAlert(avm.SelectedAlbum.Title, avm.SelectedAlbum.Artist, "OK");

            }



        }
    }
}
using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVaultApp.Model;
using VinylVaultApp.ViewModel;
using Xamarin.Forms;

namespace VinylVaultApp.View
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        AlbumViewModel avm;
        List<AlbumModel> albumList;


        public MainPage()
        {
            InitializeComponent();

            avm = new AlbumViewModel();

            BindingContext = avm;


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            avm.CollectionName = "Carys Rock Collection";

            await RefreshListView();
        }


        public async Task<bool> RefreshListView()
        {

            listView.ItemsSource = null;
            await avm.GetAlbums();
            albumList = avm.albumList;
            listView.ItemsSource = albumList;
            return true;
        }




        private async void btnName_Clicked(object sender, EventArgs e)
        {
            PromptConfig pc = new PromptConfig();
            pc.Title = "Collection Name";
            pc.Message = "Choose a Collection Name";

            var result = await UserDialogs.Instance.PromptAsync(pc);

            if (result.Ok && result.Text != "")
            {
                avm.CollectionName = result.Text;

            }
  
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                avm.selectedAlbum = (AlbumModel)e.SelectedItem;
                await DisplayAlert(avm.selectedAlbum.Title, avm.selectedAlbum.Artist, "OK");

            }


        }

        private void srchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(e.NewTextValue))
            {
                listView.ItemsSource = albumList;
            }
            else
            {
                listView.ItemsSource = albumList.Where(x => x.Title.ToLower().Contains(e.NewTextValue.ToLower()));

            }



        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            AlbumModel alb = (AlbumModel)mi.CommandParameter;
            if (await DisplayAlert("Delete Album", alb.Title, "Yes", "No"))
            {
                await avm.DeleteAlbum(alb);
                await RefreshListView();


            }
        }
    }
}

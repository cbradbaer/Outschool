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
                avm.SelectedAlbum = alb;
                await Navigation.PushModalAsync(new DetailPage(avm, false));

            }


        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DetailPage(avm, true));

            await RefreshListView();

        }

        private void srchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == null || e.NewTextValue == "")
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
            if(await DisplayAlert("Delete Album?", alb.Title, "Yes", "No"))
            {
                avm.DeleteAlbum(alb);
                await RefreshListView();
            }


        }
    }
}
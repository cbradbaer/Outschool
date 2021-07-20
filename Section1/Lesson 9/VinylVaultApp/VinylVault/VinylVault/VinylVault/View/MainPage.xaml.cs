using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVault.Model;
using VinylVault.View;
using VinylVault.ViewModel;
using Xamarin.Forms;

namespace VinylVault
{
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
            avm.CollectionName = "Cary's Classic Collection";
            RefreshListView();
        }


        public bool RefreshListView()
        {

            listview.ItemsSource = null;
            avm.GetAlbums();
            listview.ItemsSource = avm.AlbumList;
            albumList = avm.AlbumList;
            return true;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            PromptConfig prompt = new PromptConfig();
            prompt.Title = "Collection Name";
            prompt.Message = "Choose a Collection Name";

           var result = await UserDialogs.Instance.PromptAsync(prompt);

            if (result.Ok && result.Text != string.Empty)
            {
                avm.CollectionName = result.Text;
            }

        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            AlbumModel alb = (AlbumModel)mi.CommandParameter;

            if(await DisplayAlert("Delete Album", alb.Title, "Yes","No"))
            {
                avm.DeleteAlbum(alb);
                RefreshListView();
            }
            
        }

        private void srchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(e.NewTextValue == string.Empty)
            {
                listview.ItemsSource = albumList;
            }
            else
            {
                listview.ItemsSource = albumList.Where(x => x.Title.ToLower().Contains(e.NewTextValue.ToLower()));

            }



        }

        private async void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                avm.SelectedAlbum = (AlbumModel)e.SelectedItem;
                await Navigation.PushModalAsync(new AlbumDetailPage());

            }
        }
    }
}

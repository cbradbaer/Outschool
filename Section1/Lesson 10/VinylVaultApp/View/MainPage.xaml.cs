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
using Xamarin.Forms.Xaml;

namespace VinylVaultApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        AlbumViewModel avm;
        List<album> albumList;



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
            await RefreshListView();
        }

        private async void btnName_Clicked(object sender, EventArgs e)
        {
            //PromptConfig myPrompt = new PromptConfig();
            //myPrompt.Title = "";
            //await UserDialogs.Instance.PromptAsync(myPrompt);

            var result = await UserDialogs.Instance.PromptAsync(new PromptConfig
            {
                Title = "Collection Name",
                Message = "Choose a Collection Name"
            });

            if (result.Ok && result.Text != "")
            {
                avm.CollectionName = result.Text;
            }



        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                avm.SelectedAlbum = (album)e.SelectedItem;


                await Navigation.PushModalAsync(new DetailPage(avm, false));

                //StringBuilder sb = new StringBuilder();
                //sb.AppendLine("Model: " + avm.SelectedAlbum.Title);
                //sb.AppendLine("Make: " + avm.SelectedAlbum.Artist);
                //sb.AppendLine("Release Date: " + avm.SelectedAlbum.Title);
                //await DisplayAlert(avm.SelectedAlbum.Title, sb.ToString(), "OK");

            }


        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            album alb = (album)mi.CommandParameter;
            if (await DisplayAlert("Delete Album", alb.Title, "Yes", "No"))
            {
                avm.DeleteAlbum(alb);
                await RefreshListView();

            }
        }

        public async Task<bool> RefreshListView()
        {
            listView.ItemsSource = null;
            await avm.GetCollection();
            albumList = avm.albumList;
            listView.ItemsSource = albumList;
            return true;
        }

        private void srchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                listView.ItemsSource = albumList;
            }
            else
            {
                listView.ItemsSource = albumList.Where(x => x.Title.ToLower().Contains(e.NewTextValue.ToLower())
                                                        || x.Artist.ToLower().Contains(e.NewTextValue.ToLower()
                                                        ));
            }
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new DetailPage(avm, true));

        }
    }
}
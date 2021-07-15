using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVault.Model;
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
            listview.ItemsSource = null;
            avm.GetAlbums();
            listview.ItemsSource = avm.AlbumList;


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
    }
}

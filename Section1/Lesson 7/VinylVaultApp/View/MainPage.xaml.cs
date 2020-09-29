using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        }

        private void btnName_Clicked(object sender, EventArgs e)
        {
            avm.CollectionName = "Classic Collection";
        }
    }
}

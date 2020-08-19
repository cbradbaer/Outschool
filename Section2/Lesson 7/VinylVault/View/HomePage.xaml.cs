using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVault.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinylVault.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {

        AlbumViewModel avm;

        public HomePage()
        {
            InitializeComponent();

            avm = new AlbumViewModel();

            BindingContext = avm;


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            avm.CollectionName = "Cary Classic Collection";


        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            avm.CollectionName = "Some Other Name";

        }
    }
}
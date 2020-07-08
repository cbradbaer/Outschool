using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVaultApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinylVaultApp.View
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

        private void btnName_Clicked(object sender, EventArgs e)
        {
            avm.CollectionName = "Carys Rock Collection";

        }
    }
}
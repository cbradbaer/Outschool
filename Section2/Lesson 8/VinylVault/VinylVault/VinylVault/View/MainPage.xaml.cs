﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylVault.ViewModel;
using Xamarin.Forms;

namespace VinylVault
{
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
            avm.CollectionName = "Cary's Rock Collection";

        }

    }
}

using System;
using VinylVault.Data;
using VinylVault.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinylVault
{
    public partial class App : Application
    {

        static VinylVaultDatabase database;


        public static VinylVaultDatabase Database
        {

            get
            {
                if (database == null)
                {
                    string dbDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    database = new VinylVaultDatabase(System.IO.Path.Combine(dbDirectory, "VinylVaultSQLite.db3"));

                }


                return database;

            }


        }



        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

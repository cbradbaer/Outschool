using System;
using System.Diagnostics;
using VinylVaultApp.Data;
using VinylVaultApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinylVaultApp
{
    public partial class App : Application
    {

      static  VinylVaultDatabase database;


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

            MainPage = new MainPage();
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

        // public static VinylVaultDatabase Database
        //{
        //    get
        //    {
        //        if (database == null)
        //            { 
        //            }
        //            try
        //                {
        //                    string dbDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //                    database = new VinylVaultDatabase(System.IO.Path.Combine(dbDirectory, "VinylVaultSQLite.db3"));


        //                }
        //        catch (Exception ex)
        //            {
        //                Debug.WriteLine(ex.Message + " : " + ex.InnerException.Message);

        //            }

        //        return database;



        //    }


        //}




    }
}

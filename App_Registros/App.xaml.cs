using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Registros.Data;
//using Xamarin.Forms.Shapes;

namespace App_Registros
{
    public partial class App : Application
    {
        
        static SQLiteHelper Database;
        public static SQLiteHelper SQLiteDb
        {
            get
            {
                if (Database == null)
                {
                    Database = new
                    //Define the destination for store the data   
                    SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XamarinStudentSQLite.db3"));
                }
                return Database;
            }
        }
        
        //edits
        /*
        private static SQLiteHelper context;

        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (context == null)
                {
                    var dbPath = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "HarryPotterDB.db3");

                    context = new SQLiteHelper(dbPath);
                }

                return context;
            }
        }*/
        //edits fin

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

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

        //Edits
        /*
                static SQLiteHelper db;
                public static SQLiteHelper SQLiteDB
                {
                    get
                    {
                        if (db == null)
                        {
                            db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XamarinSQLite.db3"));
                        }
                    }
                }
               */

    }
}

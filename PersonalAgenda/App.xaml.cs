﻿using System;
using PersonalAgenda.Data;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalAgenda
{
    public partial class App : Application
    {
        static AgendaDatabase database;
        public static AgendaDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new AgendaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Notes1.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AgendaPage());
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
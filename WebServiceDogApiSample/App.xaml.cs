using System;
using WebServiceDogApiSample.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebServiceDogApiSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FavouritePage();
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

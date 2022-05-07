using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestApiApp.Models;
using TestApiApp.Views;
using TestApiApp.Services;

namespace TestApiApp
{
    public partial class App : Application
    {
        public static RequestManager RequestManager { get; private set; }
        public App()
        {
            InitializeComponent();

            RequestManager = new RequestManager(new RestService());
            MainPage = new NavigationPage(new WeatherPage()) { BarBackgroundColor = Color.Red };
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

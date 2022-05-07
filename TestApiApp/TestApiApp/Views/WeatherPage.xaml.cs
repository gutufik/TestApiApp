using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApiApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestApiApp.Models;

namespace TestApiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();

            var requestManager = new RequestManager(new RestService());
            var weather = requestManager.GetWeather("kazan");
            var w = weather.Result;
        }
    }
}
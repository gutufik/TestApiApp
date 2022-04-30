using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using TestApiApp.Models;
using Xamarin.Forms.Xaml;

namespace TestApiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatsPage : ContentPage
    {
        public CatsPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CatsLV.ItemsSource = await App.RequestManager.GetCats();
        }
        private void CatsLV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new CreateCatPage()
            {
                BindingContext = e.SelectedItem as Cat
            });
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateCatPage(true)
            {
                BindingContext = new Cat()
                {
                    id = Guid.NewGuid().ToString(),
                }
            });
        }
    }
}
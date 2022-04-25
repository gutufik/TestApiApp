using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestApiApp.Models;
using Xamarin.Essentials;

namespace TestApiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        public EntryModel EntryModel { get; set; }
        public EntryPage(EntryModel entry)
        {
            EntryModel = entry;
            InitializeComponent();
            this.BindingContext = EntryModel;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var url = (sender as Label).Text;
            Launcher.OpenAsync(new Uri(url));
        }
    }
}
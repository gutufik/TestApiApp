using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApiApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateCatPage : ContentPage
    {
        bool IsNewItem;
        public CreateCatPage(bool isNew = false)
        {
            InitializeComponent();
            IsNewItem = isNew;
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var todoItem = (Cat)BindingContext;
            await App.RequestManager.SaveItemAsync(todoItem, IsNewItem);
            await Navigation.PopAsync();
        }
        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var todoItem = (Cat)BindingContext;
            await App.RequestManager.DeleteTodoAsync(todoItem);
            await Navigation.PopAsync();
        }
    }
}
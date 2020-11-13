using System;
using System.Collections.Generic;
using Todolist.ViewModels;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Todolist.Views
{
    public partial class MainView : ContentPage
    {
        public MainView(MainViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Navigation = Navigation;
            BindingContext = viewModel;

            ItemsListView.ItemSelected += (s, e) =>
                ItemsListView.SelectedItem = null;
        }

        private async void ButtonCheckTheme_Clicked(object sender, EventArgs e)
        {
            var currentTheme = AppInfo.RequestedTheme;
            var theme = $"The theme is {currentTheme}";

            await DisplayAlert("Theme", theme, "OK");
        }
    }
}

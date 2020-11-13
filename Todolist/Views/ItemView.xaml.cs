using System;
using System.Collections.Generic;
using Todolist.ViewModels;
using Xamarin.Forms;

namespace Todolist.Views
{
    public partial class ItemView : ContentPage
    {
        public ItemView(ItemViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Navigation = Navigation;
            BindingContext = viewModel;
        }
    }
}

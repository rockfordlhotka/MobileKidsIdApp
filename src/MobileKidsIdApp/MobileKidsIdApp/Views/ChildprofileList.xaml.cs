﻿using System;

using Xamarin.Forms;

namespace MobileKidsIdApp.Views
{
    public partial class ChildProfileList : ContentPage
    {
        public ChildProfileList()
        {
            InitializeComponent();
        }

        private async void ShowChild(object sender, EventArgs e)
        {
            var child = (Models.Child)((ListView)sender).SelectedItem;
            var vm = (ViewModels.ChildProfileList)BindingContext;
            await vm.ShowChild(child);
        }
    }
}

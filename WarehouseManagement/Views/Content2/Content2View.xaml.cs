﻿using Codexzier.Maui.ApplicationFramework.Components.Data;

namespace WarehouseManagement.Views.Content2
{
    public partial class Content2View : ContentView
    {
        private Content2ViewModel _viewModel;

        public Content2View()
        {
            this.InitializeComponent();

            ViewModelManager.Load<Content2ViewModel>(vm => this.BindingContext = vm);
        }
    }
}
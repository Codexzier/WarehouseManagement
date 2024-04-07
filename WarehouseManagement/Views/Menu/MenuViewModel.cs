using Codexzier.Maui.ApplicationFramework.Views.Base;
using System.Windows.Input;
using WarehouseManagement.Views.Content1;
using WarehouseManagement.Views.Content2;
using WarehouseManagement.Views.Overview;

namespace WarehouseManagement.Views.Menu
{
    internal class MenuViewModel : BaseViewModel
    {
        private ICommand _commandOverview;

        public MenuViewModel()
        {
            this.CommandOverview = new Command(() => this.Navigation.NavigateTo<OverviewView>());
        }

        public ICommand CommandOverview
        {
            get => this._commandOverview;
            set
            {
                this._commandOverview = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandOverview));
            }
        }
    }
}
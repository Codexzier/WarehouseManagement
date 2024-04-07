using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Codexzier.Maui.ApplicationFramework.Components.Data;
using Codexzier.Maui.ApplicationFramework.Views.Base;
using WarehouseManagement.SharedBasis;

namespace WarehouseManagement.Views.Overview;

public partial class OverviewView : ContentView
{
    public OverviewView()
    {
        InitializeComponent();
        
        ViewModelManager.Load<OverviewViewModel>(vm => this.BindingContext = vm);
    }
}

public class OverviewViewModel : BaseViewModel
{
    private string _search;

    public string Search
    {
        get => this._search;
        set
        {
            this._search = value;
            this.OnNotifyPropertyChanged(nameof(this.Search));
        }
    }

    public List<ArticleItem> ArticleItems { get; set; }
}
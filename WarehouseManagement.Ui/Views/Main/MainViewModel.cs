﻿using Codexzier.Wpf.ApplicationFramework.Views.Base;
using System.Windows.Input;

namespace WarehouseManagement.Ui.Views.Main
{
    internal class MainViewModel : BaseViewModel
    {
        private ICommand _commandMessageBox;
        private ICommand _commandAskMessageBox;
        private double _value1 = 123.456d;

        public ICommand CommandMessageBox
        {
            get => this._commandMessageBox;
            set
            {
                this._commandMessageBox = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandMessageBox));
            }
        }

        public ICommand CommandAskMessageBox
        {
            get => this._commandAskMessageBox;
            set
            {
                this._commandAskMessageBox = value;
                this.OnNotifyPropertyChanged(nameof(this.CommandAskMessageBox));
            }
        }

        public double Value1
        {
            get => this._value1;
            set
            {
                this._value1 = value;
                this.OnNotifyPropertyChanged(nameof(Value1));
            }
        }
    }
}
﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HandyControl.Controls;
using HandyControl.Data;
using System;

namespace LeWpf.ViewModel
{
    public class SideMenuViewModel : ViewModelBase
    {
        public RelayCommand<FunctionEventArgs<object>> SwitchItemCmd => new Lazy<RelayCommand<FunctionEventArgs<object>>>(() =>
            new RelayCommand<FunctionEventArgs<object>>(SwitchItem)).Value;

        private void SwitchItem(FunctionEventArgs<object> info) => Growl.Info((info.Info as SideMenuItem)?.Header.ToString(), "InfoMessage");

        public RelayCommand<string> SelectCmd => new Lazy<RelayCommand<string>>(() =>
            new RelayCommand<string>(Select)).Value;

        private void Select(string header) => Growl.Success(header, "InfoMessage");
    }
}
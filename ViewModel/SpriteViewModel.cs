using GalaSoft.MvvmLight.Command;
using HandyControl.Controls;
using LeWpf.UserControl.Window;
using System;

namespace LeWpf.ViewModel
{
    public class SpriteViewModel
    {
        public RelayCommand OpenCmd => new Lazy<RelayCommand>(() =>
            new RelayCommand(() => Sprite.Show(new AppSprite()))).Value;
    }
}

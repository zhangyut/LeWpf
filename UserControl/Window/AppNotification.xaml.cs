﻿using System.Windows.Controls;

namespace LeWpf.UserControl.Window
{
    /// <summary>
    /// AppNotification.xaml 的交互逻辑
    /// </summary>
    public partial class AppNotification
    {
        public AppNotification(string info = "HandyControl")
        {
            InitializeComponent();

            textBlock.Text = info;
        }
    }
}

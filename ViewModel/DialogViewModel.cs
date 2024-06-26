﻿using LeWpf.Model;

namespace LeWpf.ViewModel
{
    public class DialogViewModel : NotificationBinding
    {
        private string content;
        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                RaisePropertyChanged("Content");
            }
        }
    }
}

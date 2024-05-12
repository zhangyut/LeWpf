using GalaSoft.MvvmLight.Command;
using HandyControl.Controls;
using HandyControl.Data;
using LeWpf.Model;
using LeWpf.UserControl.Window;
using System;

namespace LeWpf.ViewModel
{
    public class NotificationViewModel : NotificationBinding
    {
        private string textInfo;
        public string TextInfo
        {
            get { return textInfo; }
            set
            {
                textInfo = value;
                RaisePropertyChanged("TextInfo");
            }
        }

        private Array animationTypes;
        public Array AnimationTypes
        {
            get { return animationTypes; }
            set
            {
                animationTypes = value;
                RaisePropertyChanged("AnimationTypes");
            }
        }

        private ShowAnimation animationType;
        public ShowAnimation AnimationType
        {
            get { return animationType; }
            set
            {
                animationType = value;
                RaisePropertyChanged("AnimationType");
            }
        }

        private bool staysOpen;
        public bool StaysOpen
        {
            get { return staysOpen; }
            set
            {
                staysOpen = value;
                RaisePropertyChanged("StaysOpen");
            }
        }

        public RelayCommand OpenCmd => new Lazy<RelayCommand>(() =>
            new RelayCommand(() => Notification.Show(new AppNotification(TextInfo), AnimationType, StaysOpen))).Value;

        public NotificationViewModel()
        {
            TextInfo = "HandyControl";
            AnimationTypes = Enum.GetValues(typeof(ShowAnimation));
        }
    }
}

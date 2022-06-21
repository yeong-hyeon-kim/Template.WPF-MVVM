﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_MVVM.ViewModel
{
    public class AppNotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _TitleContent = "Welcome To WPF World!";

        public string TitleContent { 
            get { return _TitleContent; }
            set {
                _TitleContent = value;
                OnPropertyChanged("TitleContent");
            }
        }

        protected void OnPropertyChanged(string Message)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Message));
        }
    }
}

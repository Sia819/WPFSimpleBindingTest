﻿namespace MvvmExample.ViewModel
{
    using GalaSoft.MvvmLight;

    public class Page2ViewModel : ViewModelBase
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => Set(ref _text, value);
        }

        public Page2ViewModel()
        {
            Text = "Page2 Binding";
        }
    }
}

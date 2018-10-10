﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveMvvm.Avalonia.Services;
using ReactiveMvvm.ViewModels;
using ReactiveUI;

namespace ReactiveMvvm.Avalonia.Views
{
    public class FeedbackView : Window, IViewFor<FeedbackViewModel>
    {
        public FeedbackView()
        {
            AvaloniaXamlLoader.Load(this);
            ViewModel = new FeedbackViewModel(new AvaloniaSender());

            this.AttachDevTools();
            this.WhenActivated(disposables =>
            {
                // Handle interactions and complex scenarios...
            });
        }

        public FeedbackViewModel ViewModel
        {
            get => (FeedbackViewModel)DataContext;
            set => DataContext = value;
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (FeedbackViewModel)value;
        }
    }
}

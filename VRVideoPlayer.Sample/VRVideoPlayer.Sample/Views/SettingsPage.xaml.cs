using System;
using System.Collections.Generic;
using VRVideoPlayer.Sample.ViewModels;
using Xamarin.Forms;

namespace VRVideoPlayer.Sample.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = new SettingsViewModel();
        }
    }
}

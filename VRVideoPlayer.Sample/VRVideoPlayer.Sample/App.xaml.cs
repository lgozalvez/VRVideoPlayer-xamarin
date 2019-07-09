using System;
using VRVideoPlayer.Sample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VRVideoPlayer.Sample
{
    public partial class App : Application
    {
        public string VideoUrl { get; set; }
        
        public App()
        {
            InitializeComponent();

            //VideoUrl = "https://streams.videolan.org/streams/360/eagle_360.mp4";

            MainPage = new MainTabPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

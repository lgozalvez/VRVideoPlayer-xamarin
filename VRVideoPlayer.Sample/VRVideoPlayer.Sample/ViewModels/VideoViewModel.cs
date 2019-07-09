using System;
using Xamarin.Forms;

namespace VRVideoPlayer.Sample.ViewModels
{
    public class VideoViewModel : BaseViewModel
    {
        public string Url { get; set; }
        public bool Play { get; set; }

        public void Start()
        {
            Url = ((App)Application.Current).VideoUrl;

            Play = true;            
        }

        public void Stop()
        {
            Play = false;

            Url = string.Empty;
        }
    }
}
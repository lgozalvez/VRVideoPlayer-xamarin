using VRVideoPlayer.Sample.ViewModels;
using Xamarin.Forms;

namespace VRVideoPlayer.Sample.Views
{
    public partial class VideoPage : ContentPage
    {
        private VideoViewModel _vm;
        public VideoPage()
        {
            InitializeComponent();
            BindingContext = _vm = new VideoViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _vm.Start();
            var a = Player.Url;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _vm.Stop();
        }
    }
}

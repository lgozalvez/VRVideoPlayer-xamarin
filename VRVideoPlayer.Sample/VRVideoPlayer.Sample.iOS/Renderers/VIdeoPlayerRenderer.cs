using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;
using System.ComponentModel;
using CoreGraphics;
using VRVideoPlayer.iOS;
using VRVideoPlayer.Sample.iOS.Renderers;
using VRVideoPlayer.Sample;

[assembly: ExportRenderer(typeof(VideoPlayer), typeof(VideoPlayerRenderer))]
namespace VRVideoPlayer.Sample.iOS.Renderers
{
    public class VideoPlayerRenderer : ViewRenderer<VideoPlayer, UIView>
    {
        private VRVideoView _video360;
        private UIView _videoUIView;
        private VideoPlayer _formsPlayer;

        protected override void OnElementChanged(ElementChangedEventArgs<VideoPlayer> e)
        {
            base.OnElementChanged(e);

            _formsPlayer = e.NewElement;

            if (_formsPlayer != null)
            {
                RenderVideo(_formsPlayer.Url);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (sender is VideoPlayer _formsPlayer)
            {
                if (e.PropertyName == "Url")
                {
                    _video360.UpdateWithUrl(NSUrl.FromString(_formsPlayer.Url ?? string.Empty));
                }

                if (e.PropertyName == "Play")
                {
                    if (_formsPlayer.Play)
                    {
                        Play();
                    }
                    else
                    {
                        Stop();
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void RenderVideo(string url)
        {
            _video360 = _video360 ??
                new VRVideoView(NSUrl.FromString(url ?? string.Empty),
                new CGRect(_formsPlayer.X, _formsPlayer.Y, _formsPlayer.Width, _formsPlayer.Height),
                false);

            _videoUIView = _video360.View;

            SetNativeControl(_videoUIView);
        }

        private void Play()
        {
            if (!string.IsNullOrEmpty(_formsPlayer.Url))
            {
                _video360.UpdateWithUrl(NSUrl.FromString(_formsPlayer.Url));

                _video360.Play();

                AddSubview(_videoUIView);
                BringSubviewToFront(_videoUIView);
            }
        }

        private void Stop()
        {
            _video360.Pause();
            _video360.Stop();

            SendSubviewToBack(_videoUIView);
        }
    }
}

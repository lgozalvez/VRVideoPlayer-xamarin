using System.ComponentModel;
using System.Runtime.CompilerServices;
using PropertyChanged;
using VRVideoPlayer.Sample.Annotations;
using Xamarin.Forms;

namespace VRVideoPlayer.Sample.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public string Url
        {
            get => ((App) Application.Current).VideoUrl;
            set
            {
                ((App) Application.Current).VideoUrl = value;
            }
        }
    }
}
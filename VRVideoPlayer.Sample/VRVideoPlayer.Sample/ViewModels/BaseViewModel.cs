using System.ComponentModel;
using System.Runtime.CompilerServices;
using VRVideoPlayer.Sample.Annotations;

namespace VRVideoPlayer.Sample.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;     
    }
}
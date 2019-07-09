using System;
using Xamarin.Forms;

namespace VRVideoPlayer.Sample
{
    public class VideoPlayer : View
    {
        public string Url { get; set; }
        public static readonly BindableProperty UrlProperty =
            BindableProperty.Create(
                propertyName: "Url",
                returnType: typeof(string),
                declaringType: typeof(VideoPlayer),
                defaultValue: default(string),
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: OnUrlChanged);

        public bool Play { get; set; }
        public static readonly BindableProperty PlayProperty =
            BindableProperty.Create(
                propertyName: "Play",
                returnType: typeof(bool),
                declaringType: typeof(VideoPlayer),
                defaultValue: default(bool),
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: OnPlayChanged);

        //public Rotation CameraAngle { get; set; }
        //public static readonly BindableProperty CameraAngleProperty =
            //BindableProperty.Create(
                //propertyName: "CameraAngle",
                //returnType: typeof(Rotation),
                //declaringType: typeof(VideoPlayer),
                //defaultValue: Framework.Rotation.None,
                //defaultBindingMode: BindingMode.OneWay,
                //propertyChanged: OnCameraAngleChanged);

        private static void OnUrlChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VideoPlayer control)
            {
                control.Url = newValue.ToString();
            }
        }

        private static void OnPlayChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is VideoPlayer control)
            {
                control.Play = (bool)newValue;
            }
        }

        //private static void OnCameraAngleChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    if (bindable is VideoPlayer control)
        //    {
        //        control.CameraAngle = (Rotation)newValue;
        //    }
        //}
    }
}

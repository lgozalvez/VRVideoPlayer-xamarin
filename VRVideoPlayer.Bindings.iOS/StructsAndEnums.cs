using System;
using ObjCRuntime;

namespace VRVideoPlayer.iOS
{
	[Native]
	public enum Appearance : long
	{
		Dark = 0,
		Light = 1
	}

	[Native]
	public enum Background : long
    {
		Vibrant = 0,
		Opaque = 1
	}

	[Native]
	public enum HPosition : long
    {
		Right = 0,
		Left = 1
	}

	[Native]
	public enum VPosition : long
    {
		Top = 0,
		Bottom = 1
	}

	[Native]
	public enum Mode : long
    {
		FullScreen = 0,
		Normal = 1
	}

	[Native]
	public enum RotationMode : long
    {
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3
	}

	[Native]
	public enum VideoStatus : long
    {
		Loading = 0,
		ReadyToPlay = 1,
		Failed = 2
	}
}

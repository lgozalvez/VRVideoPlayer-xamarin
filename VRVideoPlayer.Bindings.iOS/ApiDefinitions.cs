using System;
using CoreGraphics;
using Foundation;
using UIKit;
using VRVideoPlayer;

namespace VRVideoPlayer.iOS
{
	// @interface FullScreenButton : UIButton
	[BaseType (typeof(UIButton))]
	interface FullScreenButton
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);

		// -(void)setWithMode:(enum Mode)mode;
		[Export ("setWithMode:")]
		void SetWithMode (Mode mode);
	}

	// @interface VRVideoPlayer_Swift_204 (FullScreenButton)
	[Category]
	[BaseType (typeof(FullScreenButton))]
	interface FullScreenButton_VRVideoPlayer_Swift_204
	{
	}

	// @interface VRVideoView : UIViewController
	[BaseType (typeof(UIViewController))]
	interface VRVideoView
	{
		// -(instancetype _Nonnull)initWithShow:(NSURL * _Nonnull)url in:(CGRect)frame autoPlay:(BOOL)autoPlay showFullScreenButton:(BOOL)showFullScreenButton __attribute__((objc_designated_initializer));
		[Export ("initWithShow:in:autoPlay:showFullScreenButton:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUrl url, CGRect frame, bool autoPlay, bool showFullScreenButton);

		// -(void)viewDidLayoutSubviews;
		[Export ("viewDidLayoutSubviews")]
		void ViewDidLayoutSubviews ();

		// -(BOOL)shouldHideTransitionView __attribute__((warn_unused_result));
		[Export ("shouldHideTransitionView")]
		//[Verify (MethodToProperty)]
		bool ShouldHideTransitionView { get; }

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)rotateBy:(float)angle;
		[Export ("rotateBy:")]
		void RotateBy (float angle);

		// -(void)rotate:(enum RotationMode)mode animated:(BOOL)animated duration:(double)duration;
		[Export ("rotate:animated:duration:")]
		void Rotate (RotationMode mode, bool animated, double duration);

		// -(void)updateWithUrl:(NSURL * _Nonnull)url;
		[Export ("updateWithUrl:")]
		void UpdateWithUrl (NSUrl url);

		// -(void)updateWithUrl:(NSURL * _Nonnull)url isStreaming:(BOOL)isStreaming;
		[Export ("updateWithUrl:isStreaming:")]
		void UpdateWithUrl (NSUrl url, bool isStreaming);

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)startOver;
		[Export ("startOver")]
		void StartOver ();

		// -(void)startOverWithStreaming:(BOOL)streaming;
		[Export ("startOverWithStreaming:")]
		void StartOverWithStreaming (bool streaming);

		// -(void)fullScreenWithAnimated:(BOOL)animated duration:(double)duration;
		[Export ("fullScreenWithAnimated:duration:")]
		void FullScreenWithAnimated (bool animated, double duration);

		// -(void)undoFullScreenWithAnimated:(BOOL)animated duration:(double)duration;
		[Export ("undoFullScreenWithAnimated:duration:")]
		void UndoFullScreenWithAnimated (bool animated, double duration);
	}

	// @interface VRVideoPlayer_Swift_339 (VRVideoView)
	[Category]
	[BaseType (typeof(VRVideoView))]
	interface VRVideoView_VRVideoPlayer_Swift_339
	{
		// -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey,id> * _Nullable)change context:(void * _Nullable)context;
		[Export ("observeValueForKeyPath:ofObject:change:context:")]
		unsafe void ObserveValueForKeyPath ([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] IntPtr context);
	}

	// @protocol VRVideoViewDelegate
	[Protocol, Model]
	interface VRVideoViewDelegate
	{
		// @required -(void)videoStatusChangedToStatus:(enum VideoStatus)status;
		[Abstract]
		[Export ("videoStatusChangedToStatus:")]
		void VideoStatusChangedToStatus (VideoStatus status);

		// @required -(void)loadingVideo;
		[Abstract]
		[Export ("loadingVideo")]
		void LoadingVideo ();

		// @required -(void)readyToPlayVideo;
		[Abstract]
		[Export ("readyToPlayVideo")]
		void ReadyToPlayVideo ();

		// @required -(void)failedToLoadVideo;
		[Abstract]
		[Export ("failedToLoadVideo")]
		void FailedToLoadVideo ();
	}
}

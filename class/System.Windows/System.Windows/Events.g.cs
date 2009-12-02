/*
 * Automatically generated, do not edit this file directly
 */

using Mono;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Mono {
	internal static class EventIds {
		public const int Accessibility_PerformActionEvent = 1;
		public const int BitmapImage_DownloadProgressEvent = 2;
		public const int BitmapImage_ImageFailedEvent = 3;
		public const int BitmapImage_ImageOpenedEvent = 4;
		public const int BitmapSource_PixelDataChangedEvent = 1;
		public const int Clock_CompletedEvent = 1;
		public const int Clock_CurrentStateInvalidatedEvent = 2;
		public const int Clock_CurrentTimeInvalidatedEvent = 3;
		public const int Collection_ChangedEvent = 1;
		public const int Collection_ItemChangedEvent = 2;
		public const int ContentControl_ContentChangedEvent = 20;
		public const int Control_IsEnabledChangedEvent = 19;
		public const int Deployment_AppDomainUnloadedEvent = 1;
		public const int Deployment_LayoutUpdatedEvent = 2;
		public const int Deployment_LoadedEvent = 3;
		public const int Deployment_ShuttingDownEvent = 4;
		public const int DispatcherTimer_TickEvent = 2;
		public const int Downloader_CompletedEvent = 1;
		public const int Downloader_DownloadFailedEvent = 2;
		public const int Downloader_DownloadProgressChangedEvent = 3;
		public const int EventObject_DestroyedEvent = 0;
		public const int FrameworkElement_SizeChangedEvent = 17;
		public const int FrameworkElement_TemplateAppliedEvent = 18;
		public const int Image_ImageFailedEvent = 20;
		public const int ImageBrush_DownloadProgressChangedEvent = 1;
		public const int ImageBrush_ImageFailedEvent = 2;
		public const int IMediaStream_FirstFrameEnqueuedEvent = 1;
		public const int Media_BufferingProgressChangedEvent = 1;
		public const int Media_CurrentStateChangedEvent = 2;
		public const int Media_DownloadProgressChangedEvent = 3;
		public const int Media_MediaErrorEvent = 4;
		public const int Media_OpenCompletedEvent = 5;
		public const int Media_OpeningEvent = 6;
		public const int Media_SeekCompletedEvent = 7;
		public const int Media_SeekingEvent = 8;
		public const int MediaBase_DownloadProgressChangedEvent = 19;
		public const int MediaElement_BufferingProgressChangedEvent = 19;
		public const int MediaElement_CurrentStateChangedEvent = 20;
		public const int MediaElement_DownloadProgressChangedEvent = 21;
		public const int MediaElement_LogReadyEvent = 22;
		public const int MediaElement_MarkerReachedEvent = 23;
		public const int MediaElement_MediaEndedEvent = 24;
		public const int MediaElement_MediaFailedEvent = 25;
		public const int MediaElement_MediaInvalidatedEvent = 26;
		public const int MediaElement_MediaOpenedEvent = 27;
		public const int MediaPlayer_BufferUnderflowEvent = 1;
		public const int MediaPlayer_MediaEndedEvent = 2;
		public const int MultiScaleImage_ImageFailedEvent = 20;
		public const int MultiScaleImage_ImageOpenFailedEvent = 21;
		public const int MultiScaleImage_ImageOpenSucceededEvent = 22;
		public const int MultiScaleImage_MotionFinishedEvent = 23;
		public const int MultiScaleImage_ViewportChangedEvent = 24;
		public const int PasswordBox_PasswordChangedEvent = 22;
		public const int PlaylistRoot_BufferingProgressChangedEvent = 1;
		public const int PlaylistRoot_BufferUnderflowEvent = 2;
		public const int PlaylistRoot_CurrentStateChangedEvent = 3;
		public const int PlaylistRoot_DownloadProgressChangedEvent = 4;
		public const int PlaylistRoot_EntryChangedEvent = 5;
		public const int PlaylistRoot_MediaEndedEvent = 6;
		public const int PlaylistRoot_MediaErrorEvent = 7;
		public const int PlaylistRoot_OpenCompletedEvent = 8;
		public const int PlaylistRoot_OpeningEvent = 9;
		public const int PlaylistRoot_PauseEvent = 10;
		public const int PlaylistRoot_PlayEvent = 11;
		public const int PlaylistRoot_SeekCompletedEvent = 12;
		public const int PlaylistRoot_SeekingEvent = 13;
		public const int PlaylistRoot_StopEvent = 14;
		public const int Popup_ClosedEvent = 19;
		public const int Popup_OpenedEvent = 20;
		public const int Surface_ErrorEvent = 1;
		public const int Surface_FullScreenChangeEvent = 2;
		public const int Surface_LoadEvent = 3;
		public const int Surface_ResizeEvent = 4;
		public const int Surface_SourceDownloadCompleteEvent = 5;
		public const int Surface_SourceDownloadProgressChangedEvent = 6;
		public const int TextBox_SelectionChangedEvent = 22;
		public const int TextBox_TextChangedEvent = 23;
		public const int TextBoxBase_CursorPositionChangedEvent = 20;
		public const int TextBoxBase_ModelChangedEvent = 21;
		public const int Timeline_CompletedEvent = 1;
		public const int TimeManager_RenderEvent = 1;
		public const int TimeManager_UpdateInputEvent = 2;
		public const int TimeSource_TickEvent = 1;
		public const int UIElement_GotFocusEvent = 1;
		public const int UIElement_InvalidatedEvent = 2;
		public const int UIElement_KeyDownEvent = 3;
		public const int UIElement_KeyUpEvent = 4;
		public const int UIElement_LoadedEvent = 5;
		public const int UIElement_LostFocusEvent = 6;
		public const int UIElement_LostMouseCaptureEvent = 7;
		public const int UIElement_MouseEnterEvent = 8;
		public const int UIElement_MouseLeaveEvent = 9;
		public const int UIElement_MouseLeftButtonDownEvent = 10;
		public const int UIElement_MouseLeftButtonMultiClickEvent = 11;
		public const int UIElement_MouseLeftButtonUpEvent = 12;
		public const int UIElement_MouseMoveEvent = 13;
		public const int UIElement_MouseRightButtonDownEvent = 14;
		public const int UIElement_MouseRightButtonUpEvent = 15;
		public const int UIElement_MouseWheelEvent = 16;
	}
	internal static partial class Events {
		public static UnmanagedEventHandler CreateDispatcherFromEventId (int eventId, Delegate value) {
			switch (eventId) {
				case EventIds.UIElement_KeyDownEvent: return Events.CreateKeyEventHandlerDispatcher ((KeyEventHandler) value);
				case EventIds.UIElement_KeyUpEvent: return Events.CreateKeyEventHandlerDispatcher ((KeyEventHandler) value);
				case EventIds.UIElement_LoadedEvent: return Events.CreateRoutedEventHandlerDispatcher ((RoutedEventHandler) value);
				case EventIds.UIElement_MouseLeftButtonDownEvent: return Events.CreateMouseButtonEventHandlerDispatcher ((MouseButtonEventHandler) value);
				case EventIds.UIElement_MouseLeftButtonUpEvent: return Events.CreateMouseButtonEventHandlerDispatcher ((MouseButtonEventHandler) value);
				default: throw new NotSupportedException ();
			}
		}
	}
}
namespace System.Windows {
	partial class FrameworkElement {

		public event RoutedEventHandler Loaded {
			add { RegisterEvent (EventIds.UIElement_LoadedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_LoadedEvent, value); }
		}
		public static readonly RoutedEvent LoadedEvent = new RoutedEvent (EventIds.UIElement_LoadedEvent);

		public event SizeChangedEventHandler SizeChanged {
			add { RegisterEvent (EventIds.FrameworkElement_SizeChangedEvent, value, Events.CreateSizeChangedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.FrameworkElement_SizeChangedEvent, value); }
		}
	}

	partial class UIElement {

		public event RoutedEventHandler GotFocus {
			add { RegisterEvent (EventIds.UIElement_GotFocusEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_GotFocusEvent, value); }
		}

		public event KeyEventHandler KeyDown {
			add { RegisterEvent (EventIds.UIElement_KeyDownEvent, value, Events.CreateKeyEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_KeyDownEvent, value); }
		}
		public static readonly RoutedEvent KeyDownEvent = new RoutedEvent (EventIds.UIElement_KeyDownEvent);

		public event KeyEventHandler KeyUp {
			add { RegisterEvent (EventIds.UIElement_KeyUpEvent, value, Events.CreateKeyEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_KeyUpEvent, value); }
		}
		public static readonly RoutedEvent KeyUpEvent = new RoutedEvent (EventIds.UIElement_KeyUpEvent);

		public event RoutedEventHandler LostFocus {
			add { RegisterEvent (EventIds.UIElement_LostFocusEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_LostFocusEvent, value); }
		}

		public event MouseEventHandler LostMouseCapture {
			add { RegisterEvent (EventIds.UIElement_LostMouseCaptureEvent, value, Events.CreateMouseEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_LostMouseCaptureEvent, value); }
		}

		public event MouseEventHandler MouseEnter {
			add { RegisterEvent (EventIds.UIElement_MouseEnterEvent, value, Events.CreateMouseEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_MouseEnterEvent, value); }
		}

		public event MouseEventHandler MouseLeave {
			add { RegisterEvent (EventIds.UIElement_MouseLeaveEvent, value, Events.CreateMouseEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_MouseLeaveEvent, value); }
		}

		public event MouseButtonEventHandler MouseLeftButtonDown {
			add { RegisterEvent (EventIds.UIElement_MouseLeftButtonDownEvent, value, Events.CreateMouseButtonEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_MouseLeftButtonDownEvent, value); }
		}
		public static readonly RoutedEvent MouseLeftButtonDownEvent = new RoutedEvent (EventIds.UIElement_MouseLeftButtonDownEvent);

		public event MouseButtonEventHandler MouseLeftButtonUp {
			add { RegisterEvent (EventIds.UIElement_MouseLeftButtonUpEvent, value, Events.CreateMouseButtonEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_MouseLeftButtonUpEvent, value); }
		}
		public static readonly RoutedEvent MouseLeftButtonUpEvent = new RoutedEvent (EventIds.UIElement_MouseLeftButtonUpEvent);

		public event MouseEventHandler MouseMove {
			add { RegisterEvent (EventIds.UIElement_MouseMoveEvent, value, Events.CreateMouseEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_MouseMoveEvent, value); }
		}

		public event MouseWheelEventHandler MouseWheel {
			add { RegisterEvent (EventIds.UIElement_MouseWheelEvent, value, Events.CreateMouseWheelEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.UIElement_MouseWheelEvent, value); }
		}
	}
}

namespace System.Windows.Controls {
	partial class Control {

		public event DependencyPropertyChangedEventHandler IsEnabledChanged {
			add { RegisterEvent (EventIds.Control_IsEnabledChangedEvent, value, Events.CreateDependencyPropertyChangedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.Control_IsEnabledChangedEvent, value); }
		}
	}

	partial class Image {

		public event EventHandler<ExceptionRoutedEventArgs> ImageFailed {
			add { RegisterEvent (EventIds.Image_ImageFailedEvent, value, Events.CreateExceptionRoutedEventArgsEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.Image_ImageFailedEvent, value); }
		}
	}

	partial class MediaElement {

		public event RoutedEventHandler BufferingProgressChanged {
			add { RegisterEvent (EventIds.MediaElement_BufferingProgressChangedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MediaElement_BufferingProgressChangedEvent, value); }
		}

		public event RoutedEventHandler CurrentStateChanged {
			add { RegisterEvent (EventIds.MediaElement_CurrentStateChangedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MediaElement_CurrentStateChangedEvent, value); }
		}

		public event RoutedEventHandler DownloadProgressChanged {
			add { RegisterEvent (EventIds.MediaElement_DownloadProgressChangedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MediaElement_DownloadProgressChangedEvent, value); }
		}

		public event LogReadyRoutedEventHandler LogReady {
			add { RegisterEvent (EventIds.MediaElement_LogReadyEvent, value, Events.CreateLogReadyRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MediaElement_LogReadyEvent, value); }
		}

		public event TimelineMarkerRoutedEventHandler MarkerReached {
			add { RegisterEvent (EventIds.MediaElement_MarkerReachedEvent, value, Events.CreateTimelineMarkerRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MediaElement_MarkerReachedEvent, value); }
		}

		public event RoutedEventHandler MediaEnded {
			add { RegisterEvent (EventIds.MediaElement_MediaEndedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MediaElement_MediaEndedEvent, value); }
		}

		public event EventHandler<ExceptionRoutedEventArgs> MediaFailed {
			add { RegisterEvent (EventIds.MediaElement_MediaFailedEvent, value, Events.CreateExceptionRoutedEventArgsEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MediaElement_MediaFailedEvent, value); }
		}

		public event RoutedEventHandler MediaOpened {
			add { RegisterEvent (EventIds.MediaElement_MediaOpenedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MediaElement_MediaOpenedEvent, value); }
		}
	}

	partial class MultiScaleImage {

		public event RoutedEventHandler ImageFailed {
			add { RegisterEvent (EventIds.MultiScaleImage_ImageFailedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MultiScaleImage_ImageFailedEvent, value); }
		}

		public event EventHandler<ExceptionRoutedEventArgs> ImageOpenFailed {
			add { RegisterEvent (EventIds.MultiScaleImage_ImageOpenFailedEvent, value, Events.CreateExceptionRoutedEventArgsEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MultiScaleImage_ImageOpenFailedEvent, value); }
		}

		public event RoutedEventHandler ImageOpenSucceeded {
			add { RegisterEvent (EventIds.MultiScaleImage_ImageOpenSucceededEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MultiScaleImage_ImageOpenSucceededEvent, value); }
		}

		public event RoutedEventHandler MotionFinished {
			add { RegisterEvent (EventIds.MultiScaleImage_MotionFinishedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MultiScaleImage_MotionFinishedEvent, value); }
		}

		public event RoutedEventHandler ViewportChanged {
			add { RegisterEvent (EventIds.MultiScaleImage_ViewportChangedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.MultiScaleImage_ViewportChangedEvent, value); }
		}
	}

	partial class PasswordBox {

		public event RoutedEventHandler PasswordChanged {
			add { RegisterEvent (EventIds.PasswordBox_PasswordChangedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.PasswordBox_PasswordChangedEvent, value); }
		}
	}

	partial class TextBox {

		public event RoutedEventHandler SelectionChanged {
			add { RegisterEvent (EventIds.TextBox_SelectionChangedEvent, value, Events.CreateRoutedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.TextBox_SelectionChangedEvent, value); }
		}

		public event TextChangedEventHandler TextChanged {
			add { RegisterEvent (EventIds.TextBox_TextChangedEvent, value, Events.CreateTextChangedEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.TextBox_TextChangedEvent, value); }
		}
	}
}

namespace System.Windows.Controls.Primitives {
	partial class Popup {

		public event EventHandler Closed {
			add { RegisterEvent (EventIds.Popup_ClosedEvent, value, Events.CreateEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.Popup_ClosedEvent, value); }
		}

		public event EventHandler Opened {
			add { RegisterEvent (EventIds.Popup_OpenedEvent, value, Events.CreateEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.Popup_OpenedEvent, value); }
		}
	}
}

namespace System.Windows.Media {
	partial class ImageBrush {

		public event EventHandler<ExceptionRoutedEventArgs> ImageFailed {
			add { RegisterEvent (EventIds.ImageBrush_ImageFailedEvent, value, Events.CreateExceptionRoutedEventArgsEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.ImageBrush_ImageFailedEvent, value); }
		}
	}
}

namespace System.Windows.Media.Animation {
	partial class Timeline {

		public event EventHandler Completed {
			add { RegisterEvent (EventIds.Timeline_CompletedEvent, value, Events.CreateEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.Timeline_CompletedEvent, value); }
		}
	}
}

namespace System.Windows.Media.Imaging {
	partial class BitmapImage {

		public event EventHandler<DownloadProgressEventArgs> DownloadProgress {
			add { RegisterEvent (EventIds.BitmapImage_DownloadProgressEvent, value, Events.CreateDownloadProgressEventArgsEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.BitmapImage_DownloadProgressEvent, value); }
		}

		public event EventHandler<ExceptionRoutedEventArgs> ImageFailed {
			add { RegisterEvent (EventIds.BitmapImage_ImageFailedEvent, value, Events.CreateExceptionRoutedEventArgsEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.BitmapImage_ImageFailedEvent, value); }
		}

		public event EventHandler<RoutedEventArgs> ImageOpened {
			add { RegisterEvent (EventIds.BitmapImage_ImageOpenedEvent, value, Events.CreateRoutedEventArgsEventHandlerDispatcher (value)); }
			remove { UnregisterEvent (EventIds.BitmapImage_ImageOpenedEvent, value); }
		}
	}
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[27]")]
    public const string InterfaceName_Windows_Media_IAudioBuffer = "Windows.Media.IAudioBuffer";

    [NativeTypeName("const WCHAR[26]")]
    public const string InterfaceName_Windows_Media_IAudioFrame = "Windows.Media.IAudioFrame";

    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_Media_IAudioFrameFactory =
        "Windows.Media.IAudioFrameFactory";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Media_IAutoRepeatModeChangeRequestedEventArgs =
        "Windows.Media.IAutoRepeatModeChangeRequestedEventArgs";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Media_IImageDisplayProperties =
        "Windows.Media.IImageDisplayProperties";

    [NativeTypeName("const WCHAR[28]")]
    public const string InterfaceName_Windows_Media_IMediaControl = "Windows.Media.IMediaControl";

    [NativeTypeName("const WCHAR[30]")]
    public const string InterfaceName_Windows_Media_IMediaExtension =
        "Windows.Media.IMediaExtension";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_IMediaExtensionManager =
        "Windows.Media.IMediaExtensionManager";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Media_IMediaExtensionManager2 =
        "Windows.Media.IMediaExtensionManager2";

    [NativeTypeName("const WCHAR[26]")]
    public const string InterfaceName_Windows_Media_IMediaFrame = "Windows.Media.IMediaFrame";

    [NativeTypeName("const WCHAR[27]")]
    public const string InterfaceName_Windows_Media_IMediaMarker = "Windows.Media.IMediaMarker";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_IMediaMarkerTypesStatics =
        "Windows.Media.IMediaMarkerTypesStatics";

    [NativeTypeName("const WCHAR[28]")]
    public const string InterfaceName_Windows_Media_IMediaMarkers = "Windows.Media.IMediaMarkers";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Media_IMediaProcessingTriggerDetails =
        "Windows.Media.IMediaProcessingTriggerDetails";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_IMediaTimelineController =
        "Windows.Media.IMediaTimelineController";

    [NativeTypeName("const WCHAR[40]")]
    public const string InterfaceName_Windows_Media_IMediaTimelineController2 =
        "Windows.Media.IMediaTimelineController2";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Media_IMediaTimelineControllerFailedEventArgs =
        "Windows.Media.IMediaTimelineControllerFailedEventArgs";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Media_IMusicDisplayProperties =
        "Windows.Media.IMusicDisplayProperties";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_IMusicDisplayProperties2 =
        "Windows.Media.IMusicDisplayProperties2";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_IMusicDisplayProperties3 =
        "Windows.Media.IMusicDisplayProperties3";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Media_IPlaybackPositionChangeRequestedEventArgs =
        "Windows.Media.IPlaybackPositionChangeRequestedEventArgs";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Media_IPlaybackRateChangeRequestedEventArgs =
        "Windows.Media.IPlaybackRateChangeRequestedEventArgs";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Media_IShuffleEnabledChangeRequestedEventArgs =
        "Windows.Media.IShuffleEnabledChangeRequestedEventArgs";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Media_ISystemMediaTransportControls =
        "Windows.Media.ISystemMediaTransportControls";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Media_ISystemMediaTransportControls2 =
        "Windows.Media.ISystemMediaTransportControls2";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_Media_ISystemMediaTransportControlsButtonPressedEventArgs =
        "Windows.Media.ISystemMediaTransportControlsButtonPressedEventArgs";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_Media_ISystemMediaTransportControlsDisplayUpdater =
        "Windows.Media.ISystemMediaTransportControlsDisplayUpdater";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_Media_ISystemMediaTransportControlsPropertyChangedEventArgs =
        "Windows.Media.ISystemMediaTransportControlsPropertyChangedEventArgs";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_ISystemMediaTransportControlsStatics =
        "Windows.Media.ISystemMediaTransportControlsStatics";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_Media_ISystemMediaTransportControlsTimelineProperties =
        "Windows.Media.ISystemMediaTransportControlsTimelineProperties";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Media_IVideoDisplayProperties =
        "Windows.Media.IVideoDisplayProperties";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Media_IVideoDisplayProperties2 =
        "Windows.Media.IVideoDisplayProperties2";

    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Media_IVideoEffectsStatics =
        "Windows.Media.IVideoEffectsStatics";

    [NativeTypeName("const WCHAR[26]")]
    public const string InterfaceName_Windows_Media_IVideoFrame = "Windows.Media.IVideoFrame";

    [NativeTypeName("const WCHAR[27]")]
    public const string InterfaceName_Windows_Media_IVideoFrame2 = "Windows.Media.IVideoFrame2";

    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_Media_IVideoFrameFactory =
        "Windows.Media.IVideoFrameFactory";

    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_Media_IVideoFrameStatics =
        "Windows.Media.IVideoFrameStatics";

    [NativeTypeName("const WCHAR[26]")]
    public const string RuntimeClass_Windows_Media_AudioBuffer = "Windows.Media.AudioBuffer";

    [NativeTypeName("const WCHAR[25]")]
    public const string RuntimeClass_Windows_Media_AudioFrame = "Windows.Media.AudioFrame";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Media_AutoRepeatModeChangeRequestedEventArgs =
        "Windows.Media.AutoRepeatModeChangeRequestedEventArgs";

    [NativeTypeName("const WCHAR[37]")]
    public const string RuntimeClass_Windows_Media_ImageDisplayProperties =
        "Windows.Media.ImageDisplayProperties";

    [NativeTypeName("const WCHAR[27]")]
    [Obsolete(
        "MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls."
    )]
    public const string RuntimeClass_Windows_Media_MediaControl = "Windows.Media.MediaControl";

    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Media_MediaExtensionManager =
        "Windows.Media.MediaExtensionManager";

    [NativeTypeName("const WCHAR[31]")]
    public const string RuntimeClass_Windows_Media_MediaMarkerTypes =
        "Windows.Media.MediaMarkerTypes";

    [NativeTypeName("const WCHAR[44]")]
    public const string RuntimeClass_Windows_Media_MediaProcessingTriggerDetails =
        "Windows.Media.MediaProcessingTriggerDetails";

    [NativeTypeName("const WCHAR[38]")]
    public const string RuntimeClass_Windows_Media_MediaTimelineController =
        "Windows.Media.MediaTimelineController";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Media_MediaTimelineControllerFailedEventArgs =
        "Windows.Media.MediaTimelineControllerFailedEventArgs";

    [NativeTypeName("const WCHAR[37]")]
    public const string RuntimeClass_Windows_Media_MusicDisplayProperties =
        "Windows.Media.MusicDisplayProperties";

    [NativeTypeName("const WCHAR[55]")]
    public const string RuntimeClass_Windows_Media_PlaybackPositionChangeRequestedEventArgs =
        "Windows.Media.PlaybackPositionChangeRequestedEventArgs";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Media_PlaybackRateChangeRequestedEventArgs =
        "Windows.Media.PlaybackRateChangeRequestedEventArgs";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Media_ShuffleEnabledChangeRequestedEventArgs =
        "Windows.Media.ShuffleEnabledChangeRequestedEventArgs";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Media_SystemMediaTransportControls =
        "Windows.Media.SystemMediaTransportControls";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_Media_SystemMediaTransportControlsButtonPressedEventArgs =
        "Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string RuntimeClass_Windows_Media_SystemMediaTransportControlsDisplayUpdater =
        "Windows.Media.SystemMediaTransportControlsDisplayUpdater";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_Media_SystemMediaTransportControlsPropertyChangedEventArgs =
        "Windows.Media.SystemMediaTransportControlsPropertyChangedEventArgs";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_Media_SystemMediaTransportControlsTimelineProperties =
        "Windows.Media.SystemMediaTransportControlsTimelineProperties";

    [NativeTypeName("const WCHAR[37]")]
    public const string RuntimeClass_Windows_Media_VideoDisplayProperties =
        "Windows.Media.VideoDisplayProperties";

    [NativeTypeName("const WCHAR[27]")]
    public const string RuntimeClass_Windows_Media_VideoEffects = "Windows.Media.VideoEffects";

    [NativeTypeName("const WCHAR[25]")]
    public const string RuntimeClass_Windows_Media_VideoFrame = "Windows.Media.VideoFrame";

    [NativeTypeName("#define WINDOWS_MEDIA_MEDIACONTROLCONTRACT_VERSION 0x10000")]
    public const int WINDOWS_MEDIA_MEDIACONTROLCONTRACT_VERSION = 0x10000;
}

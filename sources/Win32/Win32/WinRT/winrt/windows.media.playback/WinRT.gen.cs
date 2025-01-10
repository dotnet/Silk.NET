// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Media_Playback_IBackgroundMediaPlayerStatics =
        "Windows.Media.Playback.IBackgroundMediaPlayerStatics";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Media_Playback_ICurrentMediaPlaybackItemChangedEventArgs =
        "Windows.Media.Playback.ICurrentMediaPlaybackItemChangedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_Media_Playback_ICurrentMediaPlaybackItemChangedEventArgs2 =
        "Windows.Media.Playback.ICurrentMediaPlaybackItemChangedEventArgs2";

    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaBreak =
        "Windows.Media.Playback.IMediaBreak";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaBreakEndedEventArgs =
        "Windows.Media.Playback.IMediaBreakEndedEventArgs";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaBreakFactory =
        "Windows.Media.Playback.IMediaBreakFactory";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaBreakManager =
        "Windows.Media.Playback.IMediaBreakManager";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaBreakSchedule =
        "Windows.Media.Playback.IMediaBreakSchedule";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaBreakSeekedOverEventArgs =
        "Windows.Media.Playback.IMediaBreakSeekedOverEventArgs";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaBreakSkippedEventArgs =
        "Windows.Media.Playback.IMediaBreakSkippedEventArgs";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaBreakStartedEventArgs =
        "Windows.Media.Playback.IMediaBreakStartedEventArgs";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaEnginePlaybackSource =
        "Windows.Media.Playback.IMediaEnginePlaybackSource";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaItemDisplayProperties =
        "Windows.Media.Playback.IMediaItemDisplayProperties";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManager =
        "Windows.Media.Playback.IMediaPlaybackCommandManager";

    [NativeTypeName("const WCHAR[83]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerCommandBehavior =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerCommandBehavior";

    [NativeTypeName("const WCHAR[80]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerFastForwardReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerFastForwardReceivedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerNextReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerNextReceivedEventArgs";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerPauseReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerPauseReceivedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerPlayReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerPlayReceivedEventArgs";

    [NativeTypeName("const WCHAR[77]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerPositionReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerPositionReceivedEventArgs";

    [NativeTypeName("const WCHAR[77]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerPreviousReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerPreviousReceivedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerRateReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerRateReceivedEventArgs";

    [NativeTypeName("const WCHAR[75]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerRewindReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerRewindReceivedEventArgs";

    [NativeTypeName("const WCHAR[76]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackCommandManagerShuffleReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackCommandManagerShuffleReceivedEventArgs";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItem =
        "Windows.Media.Playback.IMediaPlaybackItem";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItem2 =
        "Windows.Media.Playback.IMediaPlaybackItem2";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItem3 =
        "Windows.Media.Playback.IMediaPlaybackItem3";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItemError =
        "Windows.Media.Playback.IMediaPlaybackItemError";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItemFactory =
        "Windows.Media.Playback.IMediaPlaybackItemFactory";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItemFactory2 =
        "Windows.Media.Playback.IMediaPlaybackItemFactory2";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItemFailedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackItemFailedEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItemOpenedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackItemOpenedEventArgs";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackItemStatics =
        "Windows.Media.Playback.IMediaPlaybackItemStatics";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackList =
        "Windows.Media.Playback.IMediaPlaybackList";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackList2 =
        "Windows.Media.Playback.IMediaPlaybackList2";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackList3 =
        "Windows.Media.Playback.IMediaPlaybackList3";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackSession =
        "Windows.Media.Playback.IMediaPlaybackSession";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackSession2 =
        "Windows.Media.Playback.IMediaPlaybackSession2";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackSession3 =
        "Windows.Media.Playback.IMediaPlaybackSession3";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackSessionBufferingStartedEventArgs =
        "Windows.Media.Playback.IMediaPlaybackSessionBufferingStartedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackSessionOutputDegradationPolicyState =
        "Windows.Media.Playback.IMediaPlaybackSessionOutputDegradationPolicyState";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackSource =
        "Windows.Media.Playback.IMediaPlaybackSource";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackSphericalVideoProjection =
        "Windows.Media.Playback.IMediaPlaybackSphericalVideoProjection";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlaybackTimedMetadataTrackList =
        "Windows.Media.Playback.IMediaPlaybackTimedMetadataTrackList";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayer =
        "Windows.Media.Playback.IMediaPlayer";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayer2 =
        "Windows.Media.Playback.IMediaPlayer2";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayer3 =
        "Windows.Media.Playback.IMediaPlayer3";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayer4 =
        "Windows.Media.Playback.IMediaPlayer4";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayer5 =
        "Windows.Media.Playback.IMediaPlayer5";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayer6 =
        "Windows.Media.Playback.IMediaPlayer6";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayer7 =
        "Windows.Media.Playback.IMediaPlayer7";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayerDataReceivedEventArgs =
        "Windows.Media.Playback.IMediaPlayerDataReceivedEventArgs";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayerEffects =
        "Windows.Media.Playback.IMediaPlayerEffects";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayerEffects2 =
        "Windows.Media.Playback.IMediaPlayerEffects2";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayerFailedEventArgs =
        "Windows.Media.Playback.IMediaPlayerFailedEventArgs";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayerRateChangedEventArgs =
        "Windows.Media.Playback.IMediaPlayerRateChangedEventArgs";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayerSource =
        "Windows.Media.Playback.IMediaPlayerSource";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayerSource2 =
        "Windows.Media.Playback.IMediaPlayerSource2";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Media_Playback_IMediaPlayerSurface =
        "Windows.Media.Playback.IMediaPlayerSurface";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Media_Playback_IPlaybackMediaMarker =
        "Windows.Media.Playback.IPlaybackMediaMarker";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Media_Playback_IPlaybackMediaMarkerFactory =
        "Windows.Media.Playback.IPlaybackMediaMarkerFactory";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Media_Playback_IPlaybackMediaMarkerReachedEventArgs =
        "Windows.Media.Playback.IPlaybackMediaMarkerReachedEventArgs";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Media_Playback_IPlaybackMediaMarkerSequence =
        "Windows.Media.Playback.IPlaybackMediaMarkerSequence";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_Media_Playback_ITimedMetadataPresentationModeChangedEventArgs =
        "Windows.Media.Playback.ITimedMetadataPresentationModeChangedEventArgs";

    [NativeTypeName("const WCHAR[45]")]
    [Obsolete("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.")]
    public const string RuntimeClass_Windows_Media_Playback_BackgroundMediaPlayer =
        "Windows.Media.Playback.BackgroundMediaPlayer";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Media_Playback_CurrentMediaPlaybackItemChangedEventArgs =
        "Windows.Media.Playback.CurrentMediaPlaybackItemChangedEventArgs";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaBreak =
        "Windows.Media.Playback.MediaBreak";

    [NativeTypeName("const WCHAR[48]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaBreakEndedEventArgs =
        "Windows.Media.Playback.MediaBreakEndedEventArgs";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaBreakManager =
        "Windows.Media.Playback.MediaBreakManager";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaBreakSchedule =
        "Windows.Media.Playback.MediaBreakSchedule";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaBreakSeekedOverEventArgs =
        "Windows.Media.Playback.MediaBreakSeekedOverEventArgs";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaBreakSkippedEventArgs =
        "Windows.Media.Playback.MediaBreakSkippedEventArgs";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaBreakStartedEventArgs =
        "Windows.Media.Playback.MediaBreakStartedEventArgs";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaItemDisplayProperties =
        "Windows.Media.Playback.MediaItemDisplayProperties";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackAudioTrackList =
        "Windows.Media.Playback.MediaPlaybackAudioTrackList";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManager =
        "Windows.Media.Playback.MediaPlaybackCommandManager";

    [NativeTypeName("const WCHAR[82]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerCommandBehavior =
        "Windows.Media.Playback.MediaPlaybackCommandManagerCommandBehavior";

    [NativeTypeName("const WCHAR[79]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerFastForwardReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerFastForwardReceivedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerNextReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerNextReceivedEventArgs";

    [NativeTypeName("const WCHAR[73]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerPauseReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerPauseReceivedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerPlayReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerPlayReceivedEventArgs";

    [NativeTypeName("const WCHAR[76]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerPositionReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerPositionReceivedEventArgs";

    [NativeTypeName("const WCHAR[76]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerPreviousReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerPreviousReceivedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerRateReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerRateReceivedEventArgs";

    [NativeTypeName("const WCHAR[74]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerRewindReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerRewindReceivedEventArgs";

    [NativeTypeName("const WCHAR[75]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackCommandManagerShuffleReceivedEventArgs =
        "Windows.Media.Playback.MediaPlaybackCommandManagerShuffleReceivedEventArgs";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackItem =
        "Windows.Media.Playback.MediaPlaybackItem";

    [NativeTypeName("const WCHAR[46]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackItemError =
        "Windows.Media.Playback.MediaPlaybackItemError";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackItemFailedEventArgs =
        "Windows.Media.Playback.MediaPlaybackItemFailedEventArgs";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackItemOpenedEventArgs =
        "Windows.Media.Playback.MediaPlaybackItemOpenedEventArgs";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackList =
        "Windows.Media.Playback.MediaPlaybackList";

    [NativeTypeName("const WCHAR[44]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackSession =
        "Windows.Media.Playback.MediaPlaybackSession";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackSessionBufferingStartedEventArgs =
        "Windows.Media.Playback.MediaPlaybackSessionBufferingStartedEventArgs";

    [NativeTypeName("const WCHAR[72]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackSessionOutputDegradationPolicyState =
        "Windows.Media.Playback.MediaPlaybackSessionOutputDegradationPolicyState";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackSphericalVideoProjection =
        "Windows.Media.Playback.MediaPlaybackSphericalVideoProjection";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackTimedMetadataTrackList =
        "Windows.Media.Playback.MediaPlaybackTimedMetadataTrackList";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlaybackVideoTrackList =
        "Windows.Media.Playback.MediaPlaybackVideoTrackList";

    [NativeTypeName("const WCHAR[35]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlayer =
        "Windows.Media.Playback.MediaPlayer";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlayerDataReceivedEventArgs =
        "Windows.Media.Playback.MediaPlayerDataReceivedEventArgs";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlayerFailedEventArgs =
        "Windows.Media.Playback.MediaPlayerFailedEventArgs";

    [NativeTypeName("const WCHAR[55]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlayerRateChangedEventArgs =
        "Windows.Media.Playback.MediaPlayerRateChangedEventArgs";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Media_Playback_MediaPlayerSurface =
        "Windows.Media.Playback.MediaPlayerSurface";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Media_Playback_PlaybackMediaMarker =
        "Windows.Media.Playback.PlaybackMediaMarker";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_Media_Playback_PlaybackMediaMarkerReachedEventArgs =
        "Windows.Media.Playback.PlaybackMediaMarkerReachedEventArgs";

    [NativeTypeName("const WCHAR[51]")]
    public const string RuntimeClass_Windows_Media_Playback_PlaybackMediaMarkerSequence =
        "Windows.Media.Playback.PlaybackMediaMarkerSequence";

    [NativeTypeName("const WCHAR[69]")]
    public const string RuntimeClass_Windows_Media_Playback_TimedMetadataPresentationModeChangedEventArgs =
        "Windows.Media.Playback.TimedMetadataPresentationModeChangedEventArgs";
}

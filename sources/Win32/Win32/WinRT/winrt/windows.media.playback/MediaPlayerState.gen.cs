// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Obsolete("Use MediaPlaybackState instead of MediaPlayerState.  For more info, see MSDN.")]
public enum MediaPlayerState
{
    MediaPlayerState_Closed = 0,
    MediaPlayerState_Opening = 1,
    MediaPlayerState_Buffering = 2,
    MediaPlayerState_Playing = 3,
    MediaPlayerState_Paused = 4,
    MediaPlayerState_Stopped = 5,
}

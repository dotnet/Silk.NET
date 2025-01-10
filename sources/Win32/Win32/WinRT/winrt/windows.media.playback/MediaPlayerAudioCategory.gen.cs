// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MediaPlayerAudioCategory
{
    MediaPlayerAudioCategory_Other = 0,
    MediaPlayerAudioCategory_Communications = 3,
    MediaPlayerAudioCategory_Alerts = 4,
    MediaPlayerAudioCategory_SoundEffects = 5,
    MediaPlayerAudioCategory_GameEffects = 6,
    MediaPlayerAudioCategory_GameMedia = 7,
    MediaPlayerAudioCategory_GameChat = 8,
    MediaPlayerAudioCategory_Speech = 9,
    MediaPlayerAudioCategory_Movie = 10,
    MediaPlayerAudioCategory_Media = 11,
}

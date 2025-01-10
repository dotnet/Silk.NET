// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MediaPlaybackSessionVideoConstrictionReason
{
    MediaPlaybackSessionVideoConstrictionReason_None = 0,
    MediaPlaybackSessionVideoConstrictionReason_VirtualMachine = 1,
    MediaPlaybackSessionVideoConstrictionReason_UnsupportedDisplayAdapter = 2,
    MediaPlaybackSessionVideoConstrictionReason_UnsignedDriver = 3,
    MediaPlaybackSessionVideoConstrictionReason_FrameServerEnabled = 4,
    MediaPlaybackSessionVideoConstrictionReason_OutputProtectionFailed = 5,
    MediaPlaybackSessionVideoConstrictionReason_Unknown = 6,
}

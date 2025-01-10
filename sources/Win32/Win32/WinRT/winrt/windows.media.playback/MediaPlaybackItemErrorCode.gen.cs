// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MediaPlaybackItemErrorCode
{
    MediaPlaybackItemErrorCode_None = 0,
    MediaPlaybackItemErrorCode_Aborted = 1,
    MediaPlaybackItemErrorCode_NetworkError = 2,
    MediaPlaybackItemErrorCode_DecodeError = 3,
    MediaPlaybackItemErrorCode_SourceNotSupportedError = 4,
    MediaPlaybackItemErrorCode_EncryptionError = 5,
}

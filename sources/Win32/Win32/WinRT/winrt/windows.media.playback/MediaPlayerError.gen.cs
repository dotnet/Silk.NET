// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MediaPlayerError
{
    MediaPlayerError_Unknown = 0,
    MediaPlayerError_Aborted = 1,
    MediaPlayerError_NetworkError = 2,
    MediaPlayerError_DecodingError = 3,
    MediaPlayerError_SourceNotSupported = 4,
}

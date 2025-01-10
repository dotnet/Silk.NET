// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum KnownVideoProfile
{
    KnownVideoProfile_VideoRecording = 0,
    KnownVideoProfile_HighQualityPhoto = 1,
    KnownVideoProfile_BalancedVideoAndPhoto = 2,
    KnownVideoProfile_VideoConferencing = 3,
    KnownVideoProfile_PhotoSequence = 4,
    KnownVideoProfile_HighFrameRate = 5,
    KnownVideoProfile_VariablePhotoSequence = 6,
    KnownVideoProfile_HdrWithWcgVideo = 7,
    KnownVideoProfile_HdrWithWcgPhoto = 8,
    KnownVideoProfile_VideoHdr8 = 9,
    KnownVideoProfile_CompressedCamera = 10,
}

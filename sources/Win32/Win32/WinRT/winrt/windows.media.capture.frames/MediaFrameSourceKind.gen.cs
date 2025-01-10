// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum MediaFrameSourceKind
{
    MediaFrameSourceKind_Custom = 0,
    MediaFrameSourceKind_Color = 1,
    MediaFrameSourceKind_Infrared = 2,
    MediaFrameSourceKind_Depth = 3,
    MediaFrameSourceKind_Audio = 4,
    MediaFrameSourceKind_Image = 5,
    MediaFrameSourceKind_Metadata = 6,
}

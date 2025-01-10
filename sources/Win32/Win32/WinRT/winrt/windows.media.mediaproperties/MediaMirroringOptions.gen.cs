// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum MediaMirroringOptions : uint
{
    MediaMirroringOptions_None = 0,
    MediaMirroringOptions_Horizontal = 0x1,
    MediaMirroringOptions_Vertical = 0x2,
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct POINTER_TOUCH_INFO
{
    public POINTER_INFO pointerInfo;

    [NativeTypeName("TOUCH_FLAGS")]
    public uint touchFlags;

    [NativeTypeName("TOUCH_MASK")]
    public uint touchMask;
    public RECT rcContact;
    public RECT rcContactRaw;

    [NativeTypeName("UINT32")]
    public uint orientation;

    [NativeTypeName("UINT32")]
    public uint pressure;
}

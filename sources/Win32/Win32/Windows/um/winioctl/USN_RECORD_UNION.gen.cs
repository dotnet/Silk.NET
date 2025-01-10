// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct USN_RECORD_UNION
{
    [FieldOffset(0)]
    public USN_RECORD_COMMON_HEADER Header;

    [FieldOffset(0)]
    [NativeTypeName("USN_RECORD_V2")]
    public USN_RECORD V2;

    [FieldOffset(0)]
    public USN_RECORD_V3 V3;

    [FieldOffset(0)]
    public USN_RECORD_V4 V4;
}

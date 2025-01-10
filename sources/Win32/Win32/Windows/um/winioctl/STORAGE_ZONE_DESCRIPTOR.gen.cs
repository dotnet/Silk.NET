// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_ZONE_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Size;
    public STORAGE_ZONE_TYPES ZoneType;
    public STORAGE_ZONE_CONDITION ZoneCondition;

    [NativeTypeName("BOOLEAN")]
    public byte ResetWritePointerRecommend;

    [NativeTypeName("BYTE[3]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    [NativeTypeName("DWORDLONG")]
    public ulong ZoneSize;

    [NativeTypeName("DWORDLONG")]
    public ulong WritePointerOffset;

    [InlineArray(3)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }
}

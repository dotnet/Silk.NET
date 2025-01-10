// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct BOOT_AREA_INFO
{
    [NativeTypeName("DWORD")]
    public uint BootSectorCount;

    [NativeTypeName(
        "struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winioctl.h:14008:5)[2]"
    )]
    public _BootSectors_e__FixedBuffer BootSectors;

    public partial struct _Anonymous_e__Struct
    {
        public LARGE_INTEGER Offset;
    }

    [InlineArray(2)]
    public partial struct _BootSectors_e__FixedBuffer
    {
        public _Anonymous_e__Struct e0;
    }
}

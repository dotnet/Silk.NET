// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_SECTION_HEADER
{
    [NativeTypeName("BYTE[8]")]
    public _Name_e__FixedBuffer Name;

    [NativeTypeName("__AnonymousRecord_winnt_L19613_C5")]
    public _Misc_e__Union Misc;

    [NativeTypeName("DWORD")]
    public uint VirtualAddress;

    [NativeTypeName("DWORD")]
    public uint SizeOfRawData;

    [NativeTypeName("DWORD")]
    public uint PointerToRawData;

    [NativeTypeName("DWORD")]
    public uint PointerToRelocations;

    [NativeTypeName("DWORD")]
    public uint PointerToLinenumbers;

    [NativeTypeName("WORD")]
    public ushort NumberOfRelocations;

    [NativeTypeName("WORD")]
    public ushort NumberOfLinenumbers;

    [NativeTypeName("DWORD")]
    public uint Characteristics;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Misc_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint PhysicalAddress;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint VirtualSize;
    }

    [InlineArray(8)]
    public partial struct _Name_e__FixedBuffer
    {
        public byte e0;
    }
}

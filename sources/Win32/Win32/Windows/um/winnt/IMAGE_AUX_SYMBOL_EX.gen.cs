// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_AUX_SYMBOL_EX
{
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19914_C5")]
    public _Sym_e__Struct Sym;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19919_C5")]
    public _File_e__Struct File;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19922_C5")]
    public _Section_e__Struct Section;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19933_C5")]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19937_C5")]
    public _CRC_e__Struct CRC;

    [UnscopedRef]
    public ref IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.TokenDef; }
    }

    [UnscopedRef]
    public Span<byte> rgbReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.rgbReserved; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Sym_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint WeakDefaultSymIndex;

        [NativeTypeName("DWORD")]
        public uint WeakSearchType;

        [NativeTypeName("BYTE[12]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(12)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _File_e__Struct
    {
        [NativeTypeName("BYTE[20]")]
        public _Name_e__FixedBuffer Name;

        [InlineArray(20)]
        public partial struct _Name_e__FixedBuffer
        {
            public byte e0;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Section_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("WORD")]
        public ushort NumberOfRelocations;

        [NativeTypeName("WORD")]
        public ushort NumberOfLinenumbers;

        [NativeTypeName("DWORD")]
        public uint CheckSum;
        public short Number;
        public byte Selection;
        public byte bReserved;
        public short HighNumber;

        [NativeTypeName("BYTE[2]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(2)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _Anonymous_e__Struct
    {
        public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

        [NativeTypeName("BYTE[2]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        [InlineArray(2)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _CRC_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint crc;

        [NativeTypeName("BYTE[16]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(16)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }
}

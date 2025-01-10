// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_AUX_SYMBOL
{
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19872_C5")]
    public _Sym_e__Struct Sym;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19892_C5")]
    public _File_e__Struct File;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19895_C5")]
    public _Section_e__Struct Section;

    [FieldOffset(0)]
    public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19906_C5")]
    public _CRC_e__Struct CRC;

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Sym_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint TagIndex;

        [NativeTypeName("__AnonymousRecord_winnt_L19874_C9")]
        public _Misc_e__Union Misc;

        [NativeTypeName("__AnonymousRecord_winnt_L19881_C9")]
        public _FcnAry_e__Union FcnAry;

        [NativeTypeName("WORD")]
        public ushort TvIndex;

        [StructLayout(LayoutKind.Explicit, Pack = 2)]
        public partial struct _Misc_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winnt_L19875_C13")]
            public _LnSz_e__Struct LnSz;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint TotalSize;

            public partial struct _LnSz_e__Struct
            {
                [NativeTypeName("WORD")]
                public ushort Linenumber;

                [NativeTypeName("WORD")]
                public ushort Size;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _FcnAry_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winnt_L19882_C13")]
            public _Function_e__Struct Function;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winnt_L19886_C13")]
            public _Array_e__Struct Array;

            [StructLayout(LayoutKind.Sequential, Pack = 2)]
            public partial struct _Function_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint PointerToLinenumber;

                [NativeTypeName("DWORD")]
                public uint PointerToNextFunction;
            }

            public partial struct _Array_e__Struct
            {
                [NativeTypeName("WORD[4]")]
                public _Dimension_e__FixedBuffer Dimension;

                [InlineArray(4)]
                public partial struct _Dimension_e__FixedBuffer
                {
                    public ushort e0;
                }
            }
        }
    }

    public partial struct _File_e__Struct
    {
        [NativeTypeName("BYTE[18]")]
        public _Name_e__FixedBuffer Name;

        [InlineArray(18)]
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
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _CRC_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint crc;

        [NativeTypeName("BYTE[14]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(14)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }
}

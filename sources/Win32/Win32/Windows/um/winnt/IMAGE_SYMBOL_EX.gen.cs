// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct IMAGE_SYMBOL_EX
{
    [NativeTypeName("__AnonymousRecord_winnt_L19718_C5")]
    public _N_e__Union N;

    [NativeTypeName("DWORD")]
    public uint Value;

    [NativeTypeName("LONG")]
    public int SectionNumber;

    [NativeTypeName("WORD")]
    public ushort Type;
    public byte StorageClass;
    public byte NumberOfAuxSymbols;

    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public partial struct _N_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("BYTE[8]")]
        public _ShortName_e__FixedBuffer ShortName;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L19720_C9")]
        public _Name_e__Struct Name;

        [FieldOffset(0)]
        [NativeTypeName("DWORD[2]")]
        public _LongName_e__FixedBuffer LongName;

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public partial struct _Name_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint Short;

            [NativeTypeName("DWORD")]
            public uint Long;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(8)]
        public partial struct _ShortName_e__FixedBuffer
        {
            public byte e0;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(2)]
        public partial struct _LongName_e__FixedBuffer
        {
            public uint e0;
        }
    }
}

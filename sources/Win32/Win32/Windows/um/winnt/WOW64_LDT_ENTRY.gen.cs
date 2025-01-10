// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WOW64_LDT_ENTRY
{
    [NativeTypeName("WORD")]
    public ushort LimitLow;

    [NativeTypeName("WORD")]
    public ushort BaseLow;

    [NativeTypeName("__AnonymousRecord_winnt_L10047_C5")]
    public _HighWord_e__Union HighWord;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _HighWord_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L10048_C9")]
        public _Bytes_e__Struct Bytes;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L10054_C9")]
        public _Bits_e__Struct Bits;

        public partial struct _Bytes_e__Struct
        {
            public byte BaseMid;
            public byte Flags1;
            public byte Flags2;
            public byte BaseHi;
        }

        public partial struct _Bits_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 8")]
            public uint BaseMid
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0xFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu); }
            }

            [NativeTypeName("DWORD : 5")]
            public uint Type
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 8) & 0x1Fu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1Fu << 8)) | ((value & 0x1Fu) << 8); }
            }

            [NativeTypeName("DWORD : 2")]
            public uint Dpl
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 13) & 0x3u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x3u << 13)) | ((value & 0x3u) << 13); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint Pres
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 15) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15); }
            }

            [NativeTypeName("DWORD : 4")]
            public uint LimitHi
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 16) & 0xFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0xFu << 16)) | ((value & 0xFu) << 16); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint Sys
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 20) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint Reserved_0
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 21) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint Default_Big
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 22) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22); }
            }

            [NativeTypeName("DWORD : 1")]
            public uint Granularity
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 23) & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23); }
            }

            [NativeTypeName("DWORD : 8")]
            public uint BaseHi
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 24) & 0xFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
            }
        }
    }
}

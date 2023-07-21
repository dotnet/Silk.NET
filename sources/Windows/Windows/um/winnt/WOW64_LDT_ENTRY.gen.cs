// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='WOW64_LDT_ENTRY.xml' path='doc/member[@name="WOW64_LDT_ENTRY"]/*' />
public partial struct WOW64_LDT_ENTRY
{
    /// <include file='WOW64_LDT_ENTRY.xml' path='doc/member[@name="WOW64_LDT_ENTRY.LimitLow"]/*' />
    [NativeTypeName("WORD")]
    public ushort LimitLow;

    /// <include file='WOW64_LDT_ENTRY.xml' path='doc/member[@name="WOW64_LDT_ENTRY.BaseLow"]/*' />
    [NativeTypeName("WORD")]
    public ushort BaseLow;

    /// <include file='WOW64_LDT_ENTRY.xml' path='doc/member[@name="WOW64_LDT_ENTRY.HighWord"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L9600_C5")]
    public _HighWord_e__Union HighWord;

    /// <include file='_HighWord_e__Union.xml' path='doc/member[@name="_HighWord_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _HighWord_e__Union
    {
        /// <include file='_HighWord_e__Union.xml' path='doc/member[@name="_HighWord_e__Union.Bytes"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L9601_C9")]
        public _Bytes_e__Struct Bytes;

        /// <include file='_HighWord_e__Union.xml' path='doc/member[@name="_HighWord_e__Union.Bits"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L9607_C9")]
        public _Bits_e__Struct Bits;

        /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct"]/*' />
        public partial struct _Bytes_e__Struct
        {
            /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct.BaseMid"]/*' />
            public byte BaseMid;

            /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct.Flags1"]/*' />
            public byte Flags1;

            /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct.Flags2"]/*' />
            public byte Flags2;

            /// <include file='_Bytes_e__Struct.xml' path='doc/member[@name="_Bytes_e__Struct.BaseHi"]/*' />
            public byte BaseHi;
        }

        /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct"]/*' />
        public partial struct _Bits_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.BaseMid"]/*' />
            [NativeTypeName("DWORD : 8")]
            public uint BaseMid
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0xFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Type"]/*' />
            [NativeTypeName("DWORD : 5")]
            public uint Type
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 8) & 0x1Fu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1Fu << 8)) | ((value & 0x1Fu) << 8);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Dpl"]/*' />
            [NativeTypeName("DWORD : 2")]
            public uint Dpl
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 13) & 0x3u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3u << 13)) | ((value & 0x3u) << 13);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Pres"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint Pres
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 15) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.LimitHi"]/*' />
            [NativeTypeName("DWORD : 4")]
            public uint LimitHi
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 16) & 0xFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFu << 16)) | ((value & 0xFu) << 16);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Sys"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint Sys
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 20) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Reserved_0"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint Reserved_0
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 21) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Default_Big"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint Default_Big
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 22) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.Granularity"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint Granularity
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 23) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23);
                }
            }

            /// <include file='_Bits_e__Struct.xml' path='doc/member[@name="_Bits_e__Struct.BaseHi"]/*' />
            [NativeTypeName("DWORD : 8")]
            public uint BaseHi
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 24) & 0xFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
                }
            }
        }
    }
}

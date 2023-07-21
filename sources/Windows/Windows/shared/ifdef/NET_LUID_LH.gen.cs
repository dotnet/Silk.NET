// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='NET_LUID_LH.xml' path='doc/member[@name="NET_LUID_LH"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct NET_LUID_LH
{
    /// <include file='NET_LUID_LH.xml' path='doc/member[@name="NET_LUID_LH.Value"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("ULONG64")]
    public ulong Value;

    /// <include file='NET_LUID_LH.xml' path='doc/member[@name="NET_LUID_LH.Info"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_ifdef_L121_C5")]
    public _Info_e__Struct Info;

    /// <include file='_Info_e__Struct.xml' path='doc/member[@name="_Info_e__Struct"]/*' />
    public partial struct _Info_e__Struct
    {
        public ulong _bitfield;

        /// <include file='_Info_e__Struct.xml' path='doc/member[@name="_Info_e__Struct.Reserved"]/*' />
        [NativeTypeName("ULONG64 : 24")]
        public ulong Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0xFFFFFFUL;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFFFFFUL) | (value & 0xFFFFFFUL);
            }
        }

        /// <include file='_Info_e__Struct.xml' path='doc/member[@name="_Info_e__Struct.NetLuidIndex"]/*' />
        [NativeTypeName("ULONG64 : 24")]
        public ulong NetLuidIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 24) & 0xFFFFFFUL;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFFFFUL << 24)) | ((value & 0xFFFFFFUL) << 24);
            }
        }

        /// <include file='_Info_e__Struct.xml' path='doc/member[@name="_Info_e__Struct.IfType"]/*' />
        [NativeTypeName("ULONG64 : 16")]
        public ulong IfType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 48) & 0xFFFFUL;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFFUL << 48)) | ((value & 0xFFFFUL) << 48);
            }
        }
    }
}

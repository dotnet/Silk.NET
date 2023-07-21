// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='DEVICE_STORAGE_RANGE_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_STORAGE_RANGE_ATTRIBUTES"]/*' />
public partial struct DEVICE_STORAGE_RANGE_ATTRIBUTES
{
    /// <include file='DEVICE_STORAGE_RANGE_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_STORAGE_RANGE_ATTRIBUTES.LengthInBytes"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong LengthInBytes;

    /// <include file='DEVICE_STORAGE_RANGE_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_STORAGE_RANGE_ATTRIBUTES.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L4357_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='DEVICE_STORAGE_RANGE_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_STORAGE_RANGE_ATTRIBUTES.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AllFlags"]/*' />
    [UnscopedRef]
    public ref uint AllFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.AllFlags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsRangeBad"]/*' />
    public uint IsRangeBad
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.IsRangeBad;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.IsRangeBad = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AllFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AllFlags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L4361_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsRangeBad"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint IsRangeBad
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                }
            }
        }
    }
}

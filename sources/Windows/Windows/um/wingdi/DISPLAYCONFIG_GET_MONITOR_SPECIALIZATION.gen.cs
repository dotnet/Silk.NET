// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION.xml' path='doc/member[@name="DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION"]/*'/>
public partial struct DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION
{
    /// <include file='DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION.xml' path='doc/member[@name="DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION.header"]/*'/>
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    /// <include file='DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION.xml' path='doc/member[@name="DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wingdi_L3212_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.isSpecializationEnabled"]/*'/>
    public uint isSpecializationEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.isSpecializationEnabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.isSpecializationEnabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.isSpecializationAvailableForMonitor"]/*'/>
    public uint isSpecializationAvailableForMonitor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.isSpecializationAvailableForMonitor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.isSpecializationAvailableForMonitor = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.isSpecializationAvailableForSystem"]/*'/>
    public uint isSpecializationAvailableForSystem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.isSpecializationAvailableForSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.isSpecializationAvailableForSystem = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*'/>
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.reserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.reserved = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*'/>
    [UnscopedRef]
    public ref uint value
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L3214_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint value;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.isSpecializationEnabled"]/*'/>
            [NativeTypeName("UINT32 : 1")]
            public uint isSpecializationEnabled
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.isSpecializationAvailableForMonitor"]/*'/>
            [NativeTypeName("UINT32 : 1")]
            public uint isSpecializationAvailableForMonitor
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 1) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.isSpecializationAvailableForSystem"]/*'/>
            [NativeTypeName("UINT32 : 1")]
            public uint isSpecializationAvailableForSystem
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 2) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*'/>
            [NativeTypeName("UINT32 : 29")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 3) & 0x1FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3);
                }
            }
        }
    }
}
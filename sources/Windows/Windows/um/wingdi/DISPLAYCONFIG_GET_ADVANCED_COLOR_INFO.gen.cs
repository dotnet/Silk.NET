// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO"]/*'/>
public partial struct DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO
{
    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.header"]/*'/>
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wingdi_L3165_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.colorEncoding"]/*'/>
    public DISPLAYCONFIG_COLOR_ENCODING colorEncoding;
    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO.bitsPerColorChannel"]/*'/>
    [NativeTypeName("UINT32")]
    public uint bitsPerColorChannel;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorSupported"]/*'/>
    public uint advancedColorSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.advancedColorSupported;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.advancedColorSupported = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorEnabled"]/*'/>
    public uint advancedColorEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.advancedColorEnabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.advancedColorEnabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wideColorEnforced"]/*'/>
    public uint wideColorEnforced
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.wideColorEnforced;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.wideColorEnforced = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorForceDisabled"]/*'/>
    public uint advancedColorForceDisabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.advancedColorForceDisabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.advancedColorForceDisabled = value;
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
        [NativeTypeName("__AnonymousRecord_wingdi_L3167_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint value;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorSupported"]/*'/>
            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorSupported
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorEnabled"]/*'/>
            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorEnabled
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wideColorEnforced"]/*'/>
            [NativeTypeName("UINT32 : 1")]
            public uint wideColorEnforced
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorForceDisabled"]/*'/>
            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorForceDisabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 3) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*'/>
            [NativeTypeName("UINT32 : 28")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 4) & 0xFFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFFFFFFu << 4)) | ((value & 0xFFFFFFFu) << 4);
                }
            }
        }
    }
}
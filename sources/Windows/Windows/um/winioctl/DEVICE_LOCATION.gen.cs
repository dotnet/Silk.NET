// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='DEVICE_LOCATION.xml' path='doc/member[@name="DEVICE_LOCATION"]/*' />
public partial struct DEVICE_LOCATION
{
    /// <include file='DEVICE_LOCATION.xml' path='doc/member[@name="DEVICE_LOCATION.Socket"]/*' />
    [NativeTypeName("DWORD")]
    public uint Socket;

    /// <include file='DEVICE_LOCATION.xml' path='doc/member[@name="DEVICE_LOCATION.Slot"]/*' />
    [NativeTypeName("DWORD")]
    public uint Slot;

    /// <include file='DEVICE_LOCATION.xml' path='doc/member[@name="DEVICE_LOCATION.Adapter"]/*' />
    [NativeTypeName("DWORD")]
    public uint Adapter;

    /// <include file='DEVICE_LOCATION.xml' path='doc/member[@name="DEVICE_LOCATION.Port"]/*' />
    [NativeTypeName("DWORD")]
    public uint Port;

    /// <include file='DEVICE_LOCATION.xml' path='doc/member[@name="DEVICE_LOCATION.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L2870_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Channel"]/*' />
    [UnscopedRef]
    public ref uint Channel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous1.Channel;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Device"]/*' />
    [UnscopedRef]
    public ref uint Device
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous1.Device;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Target"]/*' />
    [UnscopedRef]
    public ref uint Target
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous2.Target;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Lun"]/*' />
    [UnscopedRef]
    public ref uint Lun
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous2.Lun;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2872_C9")]
        public _Anonymous1_e__Struct Anonymous1;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous2"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2880_C9")]
        public _Anonymous2_e__Struct Anonymous2;

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*' />
        public partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Channel"]/*' />
            [NativeTypeName("DWORD")]
            public uint Channel;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Device"]/*' />
            [NativeTypeName("DWORD")]
            public uint Device;
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*' />
        public partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Target"]/*' />
            [NativeTypeName("DWORD")]
            public uint Target;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Lun"]/*' />
            [NativeTypeName("DWORD")]
            public uint Lun;
        }
    }
}

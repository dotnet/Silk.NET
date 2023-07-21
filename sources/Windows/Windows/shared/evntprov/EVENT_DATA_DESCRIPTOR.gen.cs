// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='EVENT_DATA_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DATA_DESCRIPTOR"]/*' />
public partial struct EVENT_DATA_DESCRIPTOR
{
    /// <include file='EVENT_DATA_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DATA_DESCRIPTOR.Ptr"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong Ptr;

    /// <include file='EVENT_DATA_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DATA_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("ULONG")]
    public uint Size;

    /// <include file='EVENT_DATA_DESCRIPTOR.xml' path='doc/member[@name="EVENT_DATA_DESCRIPTOR.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_evntprov_L182_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
    [UnscopedRef]
    public ref uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Reserved;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Type"]/*' />
    [UnscopedRef]
    public ref byte Type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Type;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved1"]/*' />
    [UnscopedRef]
    public ref byte Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Reserved1;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved2"]/*' />
    [UnscopedRef]
    public ref ushort Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Reserved2;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint Reserved;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_evntprov_L184_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Type"]/*' />
            [NativeTypeName("UCHAR")]
            public byte Type;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved1"]/*' />
            [NativeTypeName("UCHAR")]
            public byte Reserved1;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved2"]/*' />
            public ushort Reserved2;
        }
    }
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IP_ADAPTER_WINS_SERVER_ADDRESS_LH.xml' path='doc/member[@name="IP_ADAPTER_WINS_SERVER_ADDRESS_LH"]/*'/>
public unsafe partial struct IP_ADAPTER_WINS_SERVER_ADDRESS_LH
{
    /// <include file='IP_ADAPTER_WINS_SERVER_ADDRESS_LH.xml' path='doc/member[@name="IP_ADAPTER_WINS_SERVER_ADDRESS_LH.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_IPTypes_L218_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='IP_ADAPTER_WINS_SERVER_ADDRESS_LH.xml' path='doc/member[@name="IP_ADAPTER_WINS_SERVER_ADDRESS_LH.Next"]/*'/>
    [NativeTypeName("struct _IP_ADAPTER_WINS_SERVER_ADDRESS_LH *")]
    public IP_ADAPTER_WINS_SERVER_ADDRESS_LH* Next;
    /// <include file='IP_ADAPTER_WINS_SERVER_ADDRESS_LH.xml' path='doc/member[@name="IP_ADAPTER_WINS_SERVER_ADDRESS_LH.Address"]/*'/>
    public SOCKET_ADDRESS Address;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Alignment"]/*'/>
    [UnscopedRef]
    public ref ulong Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Alignment;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Length"]/*'/>
    [UnscopedRef]
    public ref uint Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Length;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*'/>
    [UnscopedRef]
    public ref uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Reserved;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Alignment"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Alignment;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_IPTypes_L220_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Length"]/*'/>
            [NativeTypeName("ULONG")]
            public uint Length;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*'/>
            [NativeTypeName("DWORD")]
            public uint Reserved;
        }
    }
}
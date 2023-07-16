// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP"]/*'/>
public unsafe partial struct IP_ADAPTER_ADDRESSES_XP
{
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_IPTypes_L353_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.Next"]/*'/>
    [NativeTypeName("struct _IP_ADAPTER_ADDRESSES_XP *")]
    public IP_ADAPTER_ADDRESSES_XP* Next;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.AdapterName"]/*'/>
    [NativeTypeName("PCHAR")]
    public sbyte* AdapterName;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.FirstUnicastAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_UNICAST_ADDRESS_XP")]
    public IP_ADAPTER_UNICAST_ADDRESS_XP* FirstUnicastAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.FirstAnycastAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_ANYCAST_ADDRESS_XP")]
    public IP_ADAPTER_ANYCAST_ADDRESS_XP* FirstAnycastAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.FirstMulticastAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_MULTICAST_ADDRESS_XP")]
    public IP_ADAPTER_MULTICAST_ADDRESS_XP* FirstMulticastAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.FirstDnsServerAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_DNS_SERVER_ADDRESS_XP")]
    public IP_ADAPTER_DNS_SERVER_ADDRESS_XP* FirstDnsServerAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.DnsSuffix"]/*'/>
    [NativeTypeName("PWCHAR")]
    public ushort* DnsSuffix;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.Description"]/*'/>
    [NativeTypeName("PWCHAR")]
    public ushort* Description;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.FriendlyName"]/*'/>
    [NativeTypeName("PWCHAR")]
    public ushort* FriendlyName;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.PhysicalAddress"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte PhysicalAddress[8];
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.PhysicalAddressLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PhysicalAddressLength;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.Mtu"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Mtu;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.IfType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IfType;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.OperStatus"]/*'/>
    public IF_OPER_STATUS OperStatus;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.Ipv6IfIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Ipv6IfIndex;
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.ZoneIndices"]/*'/>
    [NativeTypeName("DWORD[16]")]
    public fixed uint ZoneIndices[16];
    /// <include file='IP_ADAPTER_ADDRESSES_XP.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_XP.FirstPrefix"]/*'/>
    [NativeTypeName("PIP_ADAPTER_PREFIX_XP")]
    public IP_ADAPTER_PREFIX_XP* FirstPrefix;
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

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IfIndex"]/*'/>
    [UnscopedRef]
    public ref uint IfIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.IfIndex;
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
        [NativeTypeName("__AnonymousRecord_IPTypes_L355_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Length"]/*'/>
            [NativeTypeName("ULONG")]
            public uint Length;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IfIndex"]/*'/>
            [NativeTypeName("DWORD")]
            public uint IfIndex;
        }
    }
}
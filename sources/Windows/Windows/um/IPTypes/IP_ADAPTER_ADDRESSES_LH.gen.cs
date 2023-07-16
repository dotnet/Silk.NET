// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH"]/*'/>
public unsafe partial struct IP_ADAPTER_ADDRESSES_LH
{
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_IPTypes_L287_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Next"]/*'/>
    [NativeTypeName("struct _IP_ADAPTER_ADDRESSES_LH *")]
    public IP_ADAPTER_ADDRESSES_LH* Next;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.AdapterName"]/*'/>
    [NativeTypeName("PCHAR")]
    public sbyte* AdapterName;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FirstUnicastAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_UNICAST_ADDRESS_LH")]
    public IP_ADAPTER_UNICAST_ADDRESS_LH* FirstUnicastAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FirstAnycastAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_ANYCAST_ADDRESS_XP")]
    public IP_ADAPTER_ANYCAST_ADDRESS_XP* FirstAnycastAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FirstMulticastAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_MULTICAST_ADDRESS_XP")]
    public IP_ADAPTER_MULTICAST_ADDRESS_XP* FirstMulticastAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FirstDnsServerAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_DNS_SERVER_ADDRESS_XP")]
    public IP_ADAPTER_DNS_SERVER_ADDRESS_XP* FirstDnsServerAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.DnsSuffix"]/*'/>
    [NativeTypeName("PWCHAR")]
    public ushort* DnsSuffix;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Description"]/*'/>
    [NativeTypeName("PWCHAR")]
    public ushort* Description;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FriendlyName"]/*'/>
    [NativeTypeName("PWCHAR")]
    public ushort* FriendlyName;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.PhysicalAddress"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte PhysicalAddress[8];
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.PhysicalAddressLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PhysicalAddressLength;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_IPTypes_L305_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Mtu"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Mtu;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.IfType"]/*'/>
    [NativeTypeName("IFTYPE")]
    public uint IfType;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.OperStatus"]/*'/>
    public IF_OPER_STATUS OperStatus;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Ipv6IfIndex"]/*'/>
    [NativeTypeName("IF_INDEX")]
    public uint Ipv6IfIndex;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.ZoneIndices"]/*'/>
    [NativeTypeName("ULONG[16]")]
    public fixed uint ZoneIndices[16];
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FirstPrefix"]/*'/>
    [NativeTypeName("PIP_ADAPTER_PREFIX_XP")]
    public IP_ADAPTER_PREFIX_XP* FirstPrefix;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.TransmitLinkSpeed"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong TransmitLinkSpeed;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.ReceiveLinkSpeed"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ReceiveLinkSpeed;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FirstWinsServerAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_WINS_SERVER_ADDRESS_LH")]
    public IP_ADAPTER_WINS_SERVER_ADDRESS_LH* FirstWinsServerAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FirstGatewayAddress"]/*'/>
    [NativeTypeName("PIP_ADAPTER_GATEWAY_ADDRESS_LH")]
    public IP_ADAPTER_GATEWAY_ADDRESS_LH* FirstGatewayAddress;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Ipv4Metric"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Ipv4Metric;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Ipv6Metric"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Ipv6Metric;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Luid"]/*'/>
    [NativeTypeName("IF_LUID")]
    public NET_LUID_LH Luid;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Dhcpv4Server"]/*'/>
    public SOCKET_ADDRESS Dhcpv4Server;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.CompartmentId"]/*'/>
    [NativeTypeName("NET_IF_COMPARTMENT_ID")]
    public uint CompartmentId;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.NetworkGuid"]/*'/>
    [NativeTypeName("NET_IF_NETWORK_GUID")]
    public Guid NetworkGuid;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.ConnectionType"]/*'/>
    public NET_IF_CONNECTION_TYPE ConnectionType;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.TunnelType"]/*'/>
    public TUNNEL_TYPE TunnelType;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Dhcpv6Server"]/*'/>
    public SOCKET_ADDRESS Dhcpv6Server;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Dhcpv6ClientDuid"]/*'/>
    [NativeTypeName("BYTE[130]")]
    public fixed byte Dhcpv6ClientDuid[130];
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Dhcpv6ClientDuidLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Dhcpv6ClientDuidLength;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.Dhcpv6Iaid"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Dhcpv6Iaid;
    /// <include file='IP_ADAPTER_ADDRESSES_LH.xml' path='doc/member[@name="IP_ADAPTER_ADDRESSES_LH.FirstDnsSuffix"]/*'/>
    [NativeTypeName("PIP_ADAPTER_DNS_SUFFIX")]
    public IP_ADAPTER_DNS_SUFFIX* FirstDnsSuffix;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Alignment"]/*'/>
    [UnscopedRef]
    public ref ulong Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Alignment;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Length"]/*'/>
    [UnscopedRef]
    public ref uint Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous.Length;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IfIndex"]/*'/>
    [UnscopedRef]
    public ref uint IfIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous.IfIndex;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Flags"]/*'/>
    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Flags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DdnsEnabled"]/*'/>
    public uint DdnsEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.DdnsEnabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.DdnsEnabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RegisterAdapterSuffix"]/*'/>
    public uint RegisterAdapterSuffix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.RegisterAdapterSuffix;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.RegisterAdapterSuffix = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Dhcpv4Enabled"]/*'/>
    public uint Dhcpv4Enabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.Dhcpv4Enabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.Dhcpv4Enabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReceiveOnly"]/*'/>
    public uint ReceiveOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.ReceiveOnly;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.ReceiveOnly = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NoMulticast"]/*'/>
    public uint NoMulticast
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.NoMulticast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.NoMulticast = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Ipv6OtherStatefulConfig"]/*'/>
    public uint Ipv6OtherStatefulConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.Ipv6OtherStatefulConfig;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.Ipv6OtherStatefulConfig = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NetbiosOverTcpipEnabled"]/*'/>
    public uint NetbiosOverTcpipEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.NetbiosOverTcpipEnabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.NetbiosOverTcpipEnabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Ipv4Enabled"]/*'/>
    public uint Ipv4Enabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.Ipv4Enabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.Ipv4Enabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Ipv6Enabled"]/*'/>
    public uint Ipv6Enabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.Ipv6Enabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.Ipv6Enabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Ipv6ManagedAddressConfigurationSupported"]/*'/>
    public uint Ipv6ManagedAddressConfigurationSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.Ipv6ManagedAddressConfigurationSupported;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.Ipv6ManagedAddressConfigurationSupported = value;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Alignment"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Alignment;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_IPTypes_L289_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Length"]/*'/>
            [NativeTypeName("ULONG")]
            public uint Length;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IfIndex"]/*'/>
            [NativeTypeName("IF_INDEX")]
            public uint IfIndex;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Flags"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint Flags;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_IPTypes_L307_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DdnsEnabled"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint DdnsEnabled
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RegisterAdapterSuffix"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint RegisterAdapterSuffix
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Dhcpv4Enabled"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint Dhcpv4Enabled
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReceiveOnly"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint ReceiveOnly
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NoMulticast"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint NoMulticast
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 4) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Ipv6OtherStatefulConfig"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint Ipv6OtherStatefulConfig
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 5) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NetbiosOverTcpipEnabled"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint NetbiosOverTcpipEnabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 6) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Ipv4Enabled"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint Ipv4Enabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 7) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Ipv6Enabled"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint Ipv6Enabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 8) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Ipv6ManagedAddressConfigurationSupported"]/*'/>
            [NativeTypeName("ULONG : 1")]
            public uint Ipv6ManagedAddressConfigurationSupported
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 9) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
                }
            }
        }
    }
}
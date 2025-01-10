// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct IP_ADAPTER_ADDRESSES_XP
{
    [NativeTypeName("__AnonymousRecord_IPTypes_L353_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("struct _IP_ADAPTER_ADDRESSES_XP *")]
    public IP_ADAPTER_ADDRESSES_XP* Next;

    [NativeTypeName("PCHAR")]
    public sbyte* AdapterName;

    [NativeTypeName("PIP_ADAPTER_UNICAST_ADDRESS_XP")]
    public IP_ADAPTER_UNICAST_ADDRESS_XP* FirstUnicastAddress;

    [NativeTypeName("PIP_ADAPTER_ANYCAST_ADDRESS_XP")]
    public IP_ADAPTER_ANYCAST_ADDRESS_XP* FirstAnycastAddress;

    [NativeTypeName("PIP_ADAPTER_MULTICAST_ADDRESS_XP")]
    public IP_ADAPTER_MULTICAST_ADDRESS_XP* FirstMulticastAddress;

    [NativeTypeName("PIP_ADAPTER_DNS_SERVER_ADDRESS_XP")]
    public IP_ADAPTER_DNS_SERVER_ADDRESS_XP* FirstDnsServerAddress;

    [NativeTypeName("PWCHAR")]
    public ushort* DnsSuffix;

    [NativeTypeName("PWCHAR")]
    public ushort* Description;

    [NativeTypeName("PWCHAR")]
    public ushort* FriendlyName;

    [NativeTypeName("BYTE[8]")]
    public _PhysicalAddress_e__FixedBuffer PhysicalAddress;

    [NativeTypeName("DWORD")]
    public uint PhysicalAddressLength;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint Mtu;

    [NativeTypeName("DWORD")]
    public uint IfType;
    public IF_OPER_STATUS OperStatus;

    [NativeTypeName("DWORD")]
    public uint Ipv6IfIndex;

    [NativeTypeName("DWORD[16]")]
    public _ZoneIndices_e__FixedBuffer ZoneIndices;

    [NativeTypeName("PIP_ADAPTER_PREFIX_XP")]
    public IP_ADAPTER_PREFIX_XP* FirstPrefix;

    [UnscopedRef]
    public ref ulong Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Alignment; }
    }

    [UnscopedRef]
    public ref uint Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Length; }
    }

    [UnscopedRef]
    public ref uint IfIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.IfIndex; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Alignment;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_IPTypes_L355_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint Length;

            [NativeTypeName("DWORD")]
            public uint IfIndex;
        }
    }

    [InlineArray(8)]
    public partial struct _PhysicalAddress_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _ZoneIndices_e__FixedBuffer
    {
        public uint e0;
    }
}

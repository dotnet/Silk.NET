// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NET_ADDRESS_INFO
{
    public NET_ADDRESS_FORMAT Format;

    [NativeTypeName("__AnonymousRecord_iphlpapi_L1416_C4")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._NamedAddress_e__Struct NamedAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.NamedAddress; }
    }

    [UnscopedRef]
    public ref SOCKADDR_IN Ipv4Address
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Ipv4Address; }
    }

    [UnscopedRef]
    public ref SOCKADDR_IN6 Ipv6Address
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Ipv6Address; }
    }

    [UnscopedRef]
    public ref SOCKADDR IpAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.IpAddress; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_iphlpapi_L1418_C7")]
        public _NamedAddress_e__Struct NamedAddress;

        [FieldOffset(0)]
        public SOCKADDR_IN Ipv4Address;

        [FieldOffset(0)]
        public SOCKADDR_IN6 Ipv6Address;

        [FieldOffset(0)]
        public SOCKADDR IpAddress;

        public partial struct _NamedAddress_e__Struct
        {
            [NativeTypeName("WCHAR[256]")]
            public _Address_e__FixedBuffer Address;

            [NativeTypeName("WCHAR[6]")]
            public _Port_e__FixedBuffer Port;

            [InlineArray(256)]
            public partial struct _Address_e__FixedBuffer
            {
                public ushort e0;
            }

            [InlineArray(6)]
            public partial struct _Port_e__FixedBuffer
            {
                public ushort e0;
            }
        }
    }
}

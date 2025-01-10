// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IPV6
{
    [NativeTypeName("#define IPV6_ADDRESS_BITS RTL_BITS_OF(IN6_ADDR)")]
    public const uint IPV6_ADDRESS_BITS = (16 * 8);

    [NativeTypeName("#define IPV6_HOPOPTS 1")]
    public const int IPV6_HOPOPTS = 1;

    [NativeTypeName("#define IPV6_HDRINCL 2")]
    public const int IPV6_HDRINCL = 2;

    [NativeTypeName("#define IPV6_UNICAST_HOPS 4")]
    public const int IPV6_UNICAST_HOPS = 4;

    [NativeTypeName("#define IPV6_MULTICAST_IF 9")]
    public const int IPV6_MULTICAST_IF = 9;

    [NativeTypeName("#define IPV6_MULTICAST_HOPS 10")]
    public const int IPV6_MULTICAST_HOPS = 10;

    [NativeTypeName("#define IPV6_MULTICAST_LOOP 11")]
    public const int IPV6_MULTICAST_LOOP = 11;

    [NativeTypeName("#define IPV6_ADD_MEMBERSHIP 12")]
    public const int IPV6_ADD_MEMBERSHIP = 12;

    [NativeTypeName("#define IPV6_JOIN_GROUP IPV6_ADD_MEMBERSHIP")]
    public const int IPV6_JOIN_GROUP = 12;

    [NativeTypeName("#define IPV6_DROP_MEMBERSHIP 13")]
    public const int IPV6_DROP_MEMBERSHIP = 13;

    [NativeTypeName("#define IPV6_LEAVE_GROUP IPV6_DROP_MEMBERSHIP")]
    public const int IPV6_LEAVE_GROUP = 13;

    [NativeTypeName("#define IPV6_DONTFRAG 14")]
    public const int IPV6_DONTFRAG = 14;

    [NativeTypeName("#define IPV6_PKTINFO 19")]
    public const int IPV6_PKTINFO = 19;

    [NativeTypeName("#define IPV6_HOPLIMIT 21")]
    public const int IPV6_HOPLIMIT = 21;

    [NativeTypeName("#define IPV6_PROTECTION_LEVEL 23")]
    public const int IPV6_PROTECTION_LEVEL = 23;

    [NativeTypeName("#define IPV6_RECVIF 24")]
    public const int IPV6_RECVIF = 24;

    [NativeTypeName("#define IPV6_RECVDSTADDR 25")]
    public const int IPV6_RECVDSTADDR = 25;

    [NativeTypeName("#define IPV6_CHECKSUM 26")]
    public const int IPV6_CHECKSUM = 26;

    [NativeTypeName("#define IPV6_V6ONLY 27")]
    public const int IPV6_V6ONLY = 27;

    [NativeTypeName("#define IPV6_IFLIST 28")]
    public const int IPV6_IFLIST = 28;

    [NativeTypeName("#define IPV6_ADD_IFLIST 29")]
    public const int IPV6_ADD_IFLIST = 29;

    [NativeTypeName("#define IPV6_DEL_IFLIST 30")]
    public const int IPV6_DEL_IFLIST = 30;

    [NativeTypeName("#define IPV6_UNICAST_IF 31")]
    public const int IPV6_UNICAST_IF = 31;

    [NativeTypeName("#define IPV6_RTHDR 32")]
    public const int IPV6_RTHDR = 32;

    [NativeTypeName("#define IPV6_GET_IFLIST 33")]
    public const int IPV6_GET_IFLIST = 33;

    [NativeTypeName("#define IPV6_RECVRTHDR 38")]
    public const int IPV6_RECVRTHDR = 38;

    [NativeTypeName("#define IPV6_TCLASS 39")]
    public const int IPV6_TCLASS = 39;

    [NativeTypeName("#define IPV6_RECVTCLASS 40")]
    public const int IPV6_RECVTCLASS = 40;

    [NativeTypeName("#define IPV6_ECN 50")]
    public const int IPV6_ECN = 50;

    [NativeTypeName("#define IPV6_RECVECN 50")]
    public const int IPV6_RECVECN = 50;

    [NativeTypeName("#define IPV6_PKTINFO_EX 51")]
    public const int IPV6_PKTINFO_EX = 51;

    [NativeTypeName("#define IPV6_WFP_REDIRECT_RECORDS 60")]
    public const int IPV6_WFP_REDIRECT_RECORDS = 60;

    [NativeTypeName("#define IPV6_WFP_REDIRECT_CONTEXT 70")]
    public const int IPV6_WFP_REDIRECT_CONTEXT = 70;

    [NativeTypeName("#define IPV6_MTU_DISCOVER 71")]
    public const int IPV6_MTU_DISCOVER = 71;

    [NativeTypeName("#define IPV6_MTU 72")]
    public const int IPV6_MTU = 72;

    [NativeTypeName("#define IPV6_NRT_INTERFACE 74")]
    public const int IPV6_NRT_INTERFACE = 74;

    [NativeTypeName("#define IPV6_RECVERR 75")]
    public const int IPV6_RECVERR = 75;

    [NativeTypeName("#define IPV6_USER_MTU 76")]
    public const int IPV6_USER_MTU = 76;
}

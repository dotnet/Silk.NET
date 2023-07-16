// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class IP
{
    [NativeTypeName("#define IP_OPTIONS 1")]
    public const int IP_OPTIONS = 1;
    [NativeTypeName("#define IP_HDRINCL 2")]
    public const int IP_HDRINCL = 2;
    [NativeTypeName("#define IP_TOS 3")]
    public const int IP_TOS = 3;
    [NativeTypeName("#define IP_TTL 4")]
    public const int IP_TTL = 4;
    [NativeTypeName("#define IP_MULTICAST_IF 9")]
    public const int IP_MULTICAST_IF = 9;
    [NativeTypeName("#define IP_MULTICAST_TTL 10")]
    public const int IP_MULTICAST_TTL = 10;
    [NativeTypeName("#define IP_MULTICAST_LOOP 11")]
    public const int IP_MULTICAST_LOOP = 11;
    [NativeTypeName("#define IP_ADD_MEMBERSHIP 12")]
    public const int IP_ADD_MEMBERSHIP = 12;
    [NativeTypeName("#define IP_DROP_MEMBERSHIP 13")]
    public const int IP_DROP_MEMBERSHIP = 13;
    [NativeTypeName("#define IP_DONTFRAGMENT 14")]
    public const int IP_DONTFRAGMENT = 14;
    [NativeTypeName("#define IP_ADD_SOURCE_MEMBERSHIP 15")]
    public const int IP_ADD_SOURCE_MEMBERSHIP = 15;
    [NativeTypeName("#define IP_DROP_SOURCE_MEMBERSHIP 16")]
    public const int IP_DROP_SOURCE_MEMBERSHIP = 16;
    [NativeTypeName("#define IP_BLOCK_SOURCE 17")]
    public const int IP_BLOCK_SOURCE = 17;
    [NativeTypeName("#define IP_UNBLOCK_SOURCE 18")]
    public const int IP_UNBLOCK_SOURCE = 18;
    [NativeTypeName("#define IP_PKTINFO 19")]
    public const int IP_PKTINFO = 19;
    [NativeTypeName("#define IP_HOPLIMIT 21")]
    public const int IP_HOPLIMIT = 21;
    [NativeTypeName("#define IP_RECVTTL 21")]
    public const int IP_RECVTTL = 21;
    [NativeTypeName("#define IP_RECEIVE_BROADCAST 22")]
    public const int IP_RECEIVE_BROADCAST = 22;
    [NativeTypeName("#define IP_RECVIF 24")]
    public const int IP_RECVIF = 24;
    [NativeTypeName("#define IP_RECVDSTADDR 25")]
    public const int IP_RECVDSTADDR = 25;
    [NativeTypeName("#define IP_IFLIST 28")]
    public const int IP_IFLIST = 28;
    [NativeTypeName("#define IP_ADD_IFLIST 29")]
    public const int IP_ADD_IFLIST = 29;
    [NativeTypeName("#define IP_DEL_IFLIST 30")]
    public const int IP_DEL_IFLIST = 30;
    [NativeTypeName("#define IP_UNICAST_IF 31")]
    public const int IP_UNICAST_IF = 31;
    [NativeTypeName("#define IP_RTHDR 32")]
    public const int IP_RTHDR = 32;
    [NativeTypeName("#define IP_GET_IFLIST 33")]
    public const int IP_GET_IFLIST = 33;
    [NativeTypeName("#define IP_RECVRTHDR 38")]
    public const int IP_RECVRTHDR = 38;
    [NativeTypeName("#define IP_TCLASS 39")]
    public const int IP_TCLASS = 39;
    [NativeTypeName("#define IP_RECVTCLASS 40")]
    public const int IP_RECVTCLASS = 40;
    [NativeTypeName("#define IP_RECVTOS 40")]
    public const int IP_RECVTOS = 40;
    [NativeTypeName("#define IP_ORIGINAL_ARRIVAL_IF 47")]
    public const int IP_ORIGINAL_ARRIVAL_IF = 47;
    [NativeTypeName("#define IP_ECN 50")]
    public const int IP_ECN = 50;
    [NativeTypeName("#define IP_RECVECN 50")]
    public const int IP_RECVECN = 50;
    [NativeTypeName("#define IP_PKTINFO_EX 51")]
    public const int IP_PKTINFO_EX = 51;
    [NativeTypeName("#define IP_WFP_REDIRECT_RECORDS 60")]
    public const int IP_WFP_REDIRECT_RECORDS = 60;
    [NativeTypeName("#define IP_WFP_REDIRECT_CONTEXT 70")]
    public const int IP_WFP_REDIRECT_CONTEXT = 70;
    [NativeTypeName("#define IP_MTU_DISCOVER 71")]
    public const int IP_MTU_DISCOVER = 71;
    [NativeTypeName("#define IP_MTU 73")]
    public const int IP_MTU = 73;
    [NativeTypeName("#define IP_NRT_INTERFACE 74")]
    public const int IP_NRT_INTERFACE = 74;
    [NativeTypeName("#define IP_RECVERR 75")]
    public const int IP_RECVERR = 75;
    [NativeTypeName("#define IP_USER_MTU 76")]
    public const int IP_USER_MTU = 76;
    [NativeTypeName("#define IP_UNSPECIFIED_TYPE_OF_SERVICE -1")]
    public const int IP_UNSPECIFIED_TYPE_OF_SERVICE = -1;
    [NativeTypeName("#define IP_UNSPECIFIED_HOP_LIMIT -1")]
    public const int IP_UNSPECIFIED_HOP_LIMIT = -1;
    [NativeTypeName("#define IP_PROTECTION_LEVEL IPV6_PROTECTION_LEVEL")]
    public const int IP_PROTECTION_LEVEL = 23;
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO"]/*'/>
public enum MIB_IPFORWARD_PROTO
{
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolOther"]/*'/>
    RouteProtocolOther = 1,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolLocal"]/*'/>
    RouteProtocolLocal = 2,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolNetMgmt"]/*'/>
    RouteProtocolNetMgmt = 3,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolIcmp"]/*'/>
    RouteProtocolIcmp = 4,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolEgp"]/*'/>
    RouteProtocolEgp = 5,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolGgp"]/*'/>
    RouteProtocolGgp = 6,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolHello"]/*'/>
    RouteProtocolHello = 7,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolRip"]/*'/>
    RouteProtocolRip = 8,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolIsIs"]/*'/>
    RouteProtocolIsIs = 9,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolEsIs"]/*'/>
    RouteProtocolEsIs = 10,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolCisco"]/*'/>
    RouteProtocolCisco = 11,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolBbn"]/*'/>
    RouteProtocolBbn = 12,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolOspf"]/*'/>
    RouteProtocolOspf = 13,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolBgp"]/*'/>
    RouteProtocolBgp = 14,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolIdpr"]/*'/>
    RouteProtocolIdpr = 15,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolEigrp"]/*'/>
    RouteProtocolEigrp = 16,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolDvmrp"]/*'/>
    RouteProtocolDvmrp = 17,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolRpl"]/*'/>
    RouteProtocolRpl = 18,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.RouteProtocolDhcp"]/*'/>
    RouteProtocolDhcp = 19,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_OTHER"]/*'/>
    MIB_IPPROTO_OTHER = 1,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_OTHER"]/*'/>
    PROTO_IP_OTHER = 1,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_LOCAL"]/*'/>
    MIB_IPPROTO_LOCAL = 2,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_LOCAL"]/*'/>
    PROTO_IP_LOCAL = 2,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_NETMGMT"]/*'/>
    MIB_IPPROTO_NETMGMT = 3,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_NETMGMT"]/*'/>
    PROTO_IP_NETMGMT = 3,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_ICMP"]/*'/>
    MIB_IPPROTO_ICMP = 4,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_ICMP"]/*'/>
    PROTO_IP_ICMP = 4,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_EGP"]/*'/>
    MIB_IPPROTO_EGP = 5,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_EGP"]/*'/>
    PROTO_IP_EGP = 5,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_GGP"]/*'/>
    MIB_IPPROTO_GGP = 6,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_GGP"]/*'/>
    PROTO_IP_GGP = 6,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_HELLO"]/*'/>
    MIB_IPPROTO_HELLO = 7,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_HELLO"]/*'/>
    PROTO_IP_HELLO = 7,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_RIP"]/*'/>
    MIB_IPPROTO_RIP = 8,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_RIP"]/*'/>
    PROTO_IP_RIP = 8,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_IS_IS"]/*'/>
    MIB_IPPROTO_IS_IS = 9,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_IS_IS"]/*'/>
    PROTO_IP_IS_IS = 9,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_ES_IS"]/*'/>
    MIB_IPPROTO_ES_IS = 10,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_ES_IS"]/*'/>
    PROTO_IP_ES_IS = 10,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_CISCO"]/*'/>
    MIB_IPPROTO_CISCO = 11,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_CISCO"]/*'/>
    PROTO_IP_CISCO = 11,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_BBN"]/*'/>
    MIB_IPPROTO_BBN = 12,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_BBN"]/*'/>
    PROTO_IP_BBN = 12,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_OSPF"]/*'/>
    MIB_IPPROTO_OSPF = 13,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_OSPF"]/*'/>
    PROTO_IP_OSPF = 13,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_BGP"]/*'/>
    MIB_IPPROTO_BGP = 14,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_BGP"]/*'/>
    PROTO_IP_BGP = 14,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_IDPR"]/*'/>
    MIB_IPPROTO_IDPR = 15,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_IDPR"]/*'/>
    PROTO_IP_IDPR = 15,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_EIGRP"]/*'/>
    MIB_IPPROTO_EIGRP = 16,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_EIGRP"]/*'/>
    PROTO_IP_EIGRP = 16,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_DVMRP"]/*'/>
    MIB_IPPROTO_DVMRP = 17,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_DVMRP"]/*'/>
    PROTO_IP_DVMRP = 17,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_RPL"]/*'/>
    MIB_IPPROTO_RPL = 18,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_RPL"]/*'/>
    PROTO_IP_RPL = 18,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_DHCP"]/*'/>
    MIB_IPPROTO_DHCP = 19,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_DHCP"]/*'/>
    PROTO_IP_DHCP = 19,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_NT_AUTOSTATIC"]/*'/>
    MIB_IPPROTO_NT_AUTOSTATIC = 10002,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_NT_AUTOSTATIC"]/*'/>
    PROTO_IP_NT_AUTOSTATIC = 10002,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_NT_STATIC"]/*'/>
    MIB_IPPROTO_NT_STATIC = 10006,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_NT_STATIC"]/*'/>
    PROTO_IP_NT_STATIC = 10006,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.MIB_IPPROTO_NT_STATIC_NON_DOD"]/*'/>
    MIB_IPPROTO_NT_STATIC_NON_DOD = 10007,
    /// <include file='MIB_IPFORWARD_PROTO.xml' path='doc/member[@name="MIB_IPFORWARD_PROTO.PROTO_IP_NT_STATIC_NON_DOD"]/*'/>
    PROTO_IP_NT_STATIC_NON_DOD = 10007,
}
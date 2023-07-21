// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO"]/*' />
public enum IPPROTO
{
    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_HOPOPTS"]/*' />
    IPPROTO_HOPOPTS = 0,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_ICMP"]/*' />
    IPPROTO_ICMP = 1,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_IGMP"]/*' />
    IPPROTO_IGMP = 2,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_GGP"]/*' />
    IPPROTO_GGP = 3,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_IPV4"]/*' />
    IPPROTO_IPV4 = 4,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_ST"]/*' />
    IPPROTO_ST = 5,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_TCP"]/*' />
    IPPROTO_TCP = 6,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_CBT"]/*' />
    IPPROTO_CBT = 7,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_EGP"]/*' />
    IPPROTO_EGP = 8,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_IGP"]/*' />
    IPPROTO_IGP = 9,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_PUP"]/*' />
    IPPROTO_PUP = 12,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_UDP"]/*' />
    IPPROTO_UDP = 17,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_IDP"]/*' />
    IPPROTO_IDP = 22,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_RDP"]/*' />
    IPPROTO_RDP = 27,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_IPV6"]/*' />
    IPPROTO_IPV6 = 41,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_ROUTING"]/*' />
    IPPROTO_ROUTING = 43,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_FRAGMENT"]/*' />
    IPPROTO_FRAGMENT = 44,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_ESP"]/*' />
    IPPROTO_ESP = 50,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_AH"]/*' />
    IPPROTO_AH = 51,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_ICMPV6"]/*' />
    IPPROTO_ICMPV6 = 58,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_NONE"]/*' />
    IPPROTO_NONE = 59,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_DSTOPTS"]/*' />
    IPPROTO_DSTOPTS = 60,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_ND"]/*' />
    IPPROTO_ND = 77,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_ICLFXBM"]/*' />
    IPPROTO_ICLFXBM = 78,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_PIM"]/*' />
    IPPROTO_PIM = 103,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_PGM"]/*' />
    IPPROTO_PGM = 113,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_L2TP"]/*' />
    IPPROTO_L2TP = 115,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_SCTP"]/*' />
    IPPROTO_SCTP = 132,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_RAW"]/*' />
    IPPROTO_RAW = 255,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_MAX"]/*' />
    IPPROTO_MAX = 256,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_RESERVED_RAW"]/*' />
    IPPROTO_RESERVED_RAW = 257,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_RESERVED_IPSEC"]/*' />
    IPPROTO_RESERVED_IPSEC = 258,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_RESERVED_IPSECOFFLOAD"]/*' />
    IPPROTO_RESERVED_IPSECOFFLOAD = 259,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_RESERVED_WNV"]/*' />
    IPPROTO_RESERVED_WNV = 260,

    /// <include file='IPPROTO.xml' path='doc/member[@name="IPPROTO.IPPROTO_RESERVED_MAX"]/*' />
    IPPROTO_RESERVED_MAX = 261,
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ICMP6_TYPE
{
    ICMP6_DST_UNREACH = 1,
    ICMP6_PACKET_TOO_BIG = 2,
    ICMP6_TIME_EXCEEDED = 3,
    ICMP6_PARAM_PROB = 4,
    ICMP6_ECHO_REQUEST = 128,
    ICMP6_ECHO_REPLY = 129,
    ICMP6_MEMBERSHIP_QUERY = 130,
    ICMP6_MEMBERSHIP_REPORT = 131,
    ICMP6_MEMBERSHIP_REDUCTION = 132,
    ND_ROUTER_SOLICIT = 133,
    ND_ROUTER_ADVERT = 134,
    ND_NEIGHBOR_SOLICIT = 135,
    ND_NEIGHBOR_ADVERT = 136,
    ND_REDIRECT = 137,
    ICMP6_V2_MEMBERSHIP_REPORT = 143,
}

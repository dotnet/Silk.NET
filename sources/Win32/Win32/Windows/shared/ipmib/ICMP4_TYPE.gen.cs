// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ICMP4_TYPE
{
    ICMP4_ECHO_REPLY = 0,
    ICMP4_DST_UNREACH = 3,
    ICMP4_SOURCE_QUENCH = 4,
    ICMP4_REDIRECT = 5,
    ICMP4_ECHO_REQUEST = 8,
    ICMP4_ROUTER_ADVERT = 9,
    ICMP4_ROUTER_SOLICIT = 10,
    ICMP4_TIME_EXCEEDED = 11,
    ICMP4_PARAM_PROB = 12,
    ICMP4_TIMESTAMP_REQUEST = 13,
    ICMP4_TIMESTAMP_REPLY = 14,
    ICMP4_MASK_REQUEST = 17,
    ICMP4_MASK_REPLY = 18,
}

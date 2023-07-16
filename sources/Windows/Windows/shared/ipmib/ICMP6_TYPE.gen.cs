// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE"]/*'/>
public enum ICMP6_TYPE
{
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_DST_UNREACH"]/*'/>
    ICMP6_DST_UNREACH = 1,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_PACKET_TOO_BIG"]/*'/>
    ICMP6_PACKET_TOO_BIG = 2,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_TIME_EXCEEDED"]/*'/>
    ICMP6_TIME_EXCEEDED = 3,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_PARAM_PROB"]/*'/>
    ICMP6_PARAM_PROB = 4,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_ECHO_REQUEST"]/*'/>
    ICMP6_ECHO_REQUEST = 128,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_ECHO_REPLY"]/*'/>
    ICMP6_ECHO_REPLY = 129,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_MEMBERSHIP_QUERY"]/*'/>
    ICMP6_MEMBERSHIP_QUERY = 130,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_MEMBERSHIP_REPORT"]/*'/>
    ICMP6_MEMBERSHIP_REPORT = 131,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_MEMBERSHIP_REDUCTION"]/*'/>
    ICMP6_MEMBERSHIP_REDUCTION = 132,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ND_ROUTER_SOLICIT"]/*'/>
    ND_ROUTER_SOLICIT = 133,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ND_ROUTER_ADVERT"]/*'/>
    ND_ROUTER_ADVERT = 134,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ND_NEIGHBOR_SOLICIT"]/*'/>
    ND_NEIGHBOR_SOLICIT = 135,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ND_NEIGHBOR_ADVERT"]/*'/>
    ND_NEIGHBOR_ADVERT = 136,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ND_REDIRECT"]/*'/>
    ND_REDIRECT = 137,
    /// <include file='ICMP6_TYPE.xml' path='doc/member[@name="ICMP6_TYPE.ICMP6_V2_MEMBERSHIP_REPORT"]/*'/>
    ICMP6_V2_MEMBERSHIP_REPORT = 143,
}
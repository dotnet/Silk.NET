// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE"]/*'/>
public enum ICMP4_TYPE
{
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_ECHO_REPLY"]/*'/>
    ICMP4_ECHO_REPLY = 0,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_DST_UNREACH"]/*'/>
    ICMP4_DST_UNREACH = 3,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_SOURCE_QUENCH"]/*'/>
    ICMP4_SOURCE_QUENCH = 4,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_REDIRECT"]/*'/>
    ICMP4_REDIRECT = 5,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_ECHO_REQUEST"]/*'/>
    ICMP4_ECHO_REQUEST = 8,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_ROUTER_ADVERT"]/*'/>
    ICMP4_ROUTER_ADVERT = 9,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_ROUTER_SOLICIT"]/*'/>
    ICMP4_ROUTER_SOLICIT = 10,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_TIME_EXCEEDED"]/*'/>
    ICMP4_TIME_EXCEEDED = 11,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_PARAM_PROB"]/*'/>
    ICMP4_PARAM_PROB = 12,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_TIMESTAMP_REQUEST"]/*'/>
    ICMP4_TIMESTAMP_REQUEST = 13,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_TIMESTAMP_REPLY"]/*'/>
    ICMP4_TIMESTAMP_REPLY = 14,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_MASK_REQUEST"]/*'/>
    ICMP4_MASK_REQUEST = 17,
    /// <include file='ICMP4_TYPE.xml' path='doc/member[@name="ICMP4_TYPE.ICMP4_MASK_REPLY"]/*'/>
    ICMP4_MASK_REPLY = 18,
}
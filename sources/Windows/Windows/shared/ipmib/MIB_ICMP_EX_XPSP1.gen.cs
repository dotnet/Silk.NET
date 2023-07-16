// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_ICMP_EX_XPSP1.xml' path='doc/member[@name="MIB_ICMP_EX_XPSP1"]/*'/>
public partial struct MIB_ICMP_EX_XPSP1
{
    /// <include file='MIB_ICMP_EX_XPSP1.xml' path='doc/member[@name="MIB_ICMP_EX_XPSP1.icmpInStats"]/*'/>
    [NativeTypeName("MIBICMPSTATS_EX")]
    public MIBICMPSTATS_EX_XPSP1 icmpInStats;
    /// <include file='MIB_ICMP_EX_XPSP1.xml' path='doc/member[@name="MIB_ICMP_EX_XPSP1.icmpOutStats"]/*'/>
    [NativeTypeName("MIBICMPSTATS_EX")]
    public MIBICMPSTATS_EX_XPSP1 icmpOutStats;
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ICMPV6_ECHO_REPLY_LH.xml' path='doc/member[@name="ICMPV6_ECHO_REPLY_LH"]/*'/>
public partial struct ICMPV6_ECHO_REPLY_LH
{
    /// <include file='ICMPV6_ECHO_REPLY_LH.xml' path='doc/member[@name="ICMPV6_ECHO_REPLY_LH.Address"]/*'/>
    public IPV6_ADDRESS_EX Address;
    /// <include file='ICMPV6_ECHO_REPLY_LH.xml' path='doc/member[@name="ICMPV6_ECHO_REPLY_LH.Status"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Status;
    /// <include file='ICMPV6_ECHO_REPLY_LH.xml' path='doc/member[@name="ICMPV6_ECHO_REPLY_LH.RoundTripTime"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint RoundTripTime;
}
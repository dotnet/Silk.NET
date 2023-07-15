// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IP_MCAST_COUNTER_INFO.xml' path='doc/member[@name="IP_MCAST_COUNTER_INFO"]/*'/>
public partial struct IP_MCAST_COUNTER_INFO
{
    /// <include file='IP_MCAST_COUNTER_INFO.xml' path='doc/member[@name="IP_MCAST_COUNTER_INFO.InMcastOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong InMcastOctets;
    /// <include file='IP_MCAST_COUNTER_INFO.xml' path='doc/member[@name="IP_MCAST_COUNTER_INFO.OutMcastOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong OutMcastOctets;
    /// <include file='IP_MCAST_COUNTER_INFO.xml' path='doc/member[@name="IP_MCAST_COUNTER_INFO.InMcastPkts"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong InMcastPkts;
    /// <include file='IP_MCAST_COUNTER_INFO.xml' path='doc/member[@name="IP_MCAST_COUNTER_INFO.OutMcastPkts"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong OutMcastPkts;
}
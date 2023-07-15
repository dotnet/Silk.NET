// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ICMP_ECHO_REPLY.xml' path='doc/member[@name="ICMP_ECHO_REPLY"]/*'/>
public unsafe partial struct ICMP_ECHO_REPLY
{
    /// <include file='ICMP_ECHO_REPLY.xml' path='doc/member[@name="ICMP_ECHO_REPLY.Address"]/*'/>
    [NativeTypeName("IPAddr")]
    public uint Address;
    /// <include file='ICMP_ECHO_REPLY.xml' path='doc/member[@name="ICMP_ECHO_REPLY.Status"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Status;
    /// <include file='ICMP_ECHO_REPLY.xml' path='doc/member[@name="ICMP_ECHO_REPLY.RoundTripTime"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RoundTripTime;
    /// <include file='ICMP_ECHO_REPLY.xml' path='doc/member[@name="ICMP_ECHO_REPLY.DataSize"]/*'/>
    public ushort DataSize;
    /// <include file='ICMP_ECHO_REPLY.xml' path='doc/member[@name="ICMP_ECHO_REPLY.Reserved"]/*'/>
    public ushort Reserved;
    /// <include file='ICMP_ECHO_REPLY.xml' path='doc/member[@name="ICMP_ECHO_REPLY.Data"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Data;
    /// <include file='ICMP_ECHO_REPLY.xml' path='doc/member[@name="ICMP_ECHO_REPLY.Options"]/*'/>
    [NativeTypeName("struct ip_option_information")]
    public IP_OPTION_INFORMATION Options;
}
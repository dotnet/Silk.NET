// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ICMP_ECHO_REPLY32.xml' path='doc/member[@name="ICMP_ECHO_REPLY32"]/*'/>
public unsafe partial struct ICMP_ECHO_REPLY32
{
    /// <include file='ICMP_ECHO_REPLY32.xml' path='doc/member[@name="ICMP_ECHO_REPLY32.Address"]/*'/>
    [NativeTypeName("IPAddr")]
    public uint Address;
    /// <include file='ICMP_ECHO_REPLY32.xml' path='doc/member[@name="ICMP_ECHO_REPLY32.Status"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Status;
    /// <include file='ICMP_ECHO_REPLY32.xml' path='doc/member[@name="ICMP_ECHO_REPLY32.RoundTripTime"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RoundTripTime;
    /// <include file='ICMP_ECHO_REPLY32.xml' path='doc/member[@name="ICMP_ECHO_REPLY32.DataSize"]/*'/>
    public ushort DataSize;
    /// <include file='ICMP_ECHO_REPLY32.xml' path='doc/member[@name="ICMP_ECHO_REPLY32.Reserved"]/*'/>
    public ushort Reserved;
    /// <include file='ICMP_ECHO_REPLY32.xml' path='doc/member[@name="ICMP_ECHO_REPLY32.Data"]/*'/>
    [NativeTypeName("void * __ptr32")]
    public void* Data;
    /// <include file='ICMP_ECHO_REPLY32.xml' path='doc/member[@name="ICMP_ECHO_REPLY32.Options"]/*'/>
    [NativeTypeName("struct ip_option_information32")]
    public IP_OPTION_INFORMATION32 Options;
}
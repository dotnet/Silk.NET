// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_IPMCAST_IF_ENTRY.xml' path='doc/member[@name="MIB_IPMCAST_IF_ENTRY"]/*'/>
public partial struct MIB_IPMCAST_IF_ENTRY
{
    /// <include file='MIB_IPMCAST_IF_ENTRY.xml' path='doc/member[@name="MIB_IPMCAST_IF_ENTRY.dwIfIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIfIndex;
    /// <include file='MIB_IPMCAST_IF_ENTRY.xml' path='doc/member[@name="MIB_IPMCAST_IF_ENTRY.dwTtl"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTtl;
    /// <include file='MIB_IPMCAST_IF_ENTRY.xml' path='doc/member[@name="MIB_IPMCAST_IF_ENTRY.dwProtocol"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProtocol;
    /// <include file='MIB_IPMCAST_IF_ENTRY.xml' path='doc/member[@name="MIB_IPMCAST_IF_ENTRY.dwRateLimit"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRateLimit;
    /// <include file='MIB_IPMCAST_IF_ENTRY.xml' path='doc/member[@name="MIB_IPMCAST_IF_ENTRY.ulInMcastOctets"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulInMcastOctets;
    /// <include file='MIB_IPMCAST_IF_ENTRY.xml' path='doc/member[@name="MIB_IPMCAST_IF_ENTRY.ulOutMcastOctets"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulOutMcastOctets;
}
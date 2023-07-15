// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_IPMCAST_BOUNDARY.xml' path='doc/member[@name="MIB_IPMCAST_BOUNDARY"]/*'/>
public partial struct MIB_IPMCAST_BOUNDARY
{
    /// <include file='MIB_IPMCAST_BOUNDARY.xml' path='doc/member[@name="MIB_IPMCAST_BOUNDARY.dwIfIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIfIndex;
    /// <include file='MIB_IPMCAST_BOUNDARY.xml' path='doc/member[@name="MIB_IPMCAST_BOUNDARY.dwGroupAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwGroupAddress;
    /// <include file='MIB_IPMCAST_BOUNDARY.xml' path='doc/member[@name="MIB_IPMCAST_BOUNDARY.dwGroupMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwGroupMask;
    /// <include file='MIB_IPMCAST_BOUNDARY.xml' path='doc/member[@name="MIB_IPMCAST_BOUNDARY.dwStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStatus;
}
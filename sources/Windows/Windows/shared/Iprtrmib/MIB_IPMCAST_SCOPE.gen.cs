// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE"]/*'/>
public unsafe partial struct MIB_IPMCAST_SCOPE
{
    /// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE.dwGroupAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwGroupAddress;
    /// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE.dwGroupMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwGroupMask;
    /// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE.snNameBuffer"]/*'/>
    [NativeTypeName("SCOPE_NAME_BUFFER")]
    public fixed ushort snNameBuffer[256];
    /// <include file='MIB_IPMCAST_SCOPE.xml' path='doc/member[@name="MIB_IPMCAST_SCOPE.dwStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStatus;
}
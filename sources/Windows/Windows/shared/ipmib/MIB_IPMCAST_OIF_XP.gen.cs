// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_IPMCAST_OIF_XP.xml' path='doc/member[@name="MIB_IPMCAST_OIF_XP"]/*'/>
public partial struct MIB_IPMCAST_OIF_XP
{
    /// <include file='MIB_IPMCAST_OIF_XP.xml' path='doc/member[@name="MIB_IPMCAST_OIF_XP.dwOutIfIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutIfIndex;
    /// <include file='MIB_IPMCAST_OIF_XP.xml' path='doc/member[@name="MIB_IPMCAST_OIF_XP.dwNextHopAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNextHopAddr;
    /// <include file='MIB_IPMCAST_OIF_XP.xml' path='doc/member[@name="MIB_IPMCAST_OIF_XP.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='MIB_IPMCAST_OIF_XP.xml' path='doc/member[@name="MIB_IPMCAST_OIF_XP.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
}
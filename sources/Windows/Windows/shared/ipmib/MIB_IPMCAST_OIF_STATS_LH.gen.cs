// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_IPMCAST_OIF_STATS_LH.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_LH"]/*'/>
public partial struct MIB_IPMCAST_OIF_STATS_LH
{
    /// <include file='MIB_IPMCAST_OIF_STATS_LH.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_LH.dwOutIfIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutIfIndex;
    /// <include file='MIB_IPMCAST_OIF_STATS_LH.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_LH.dwNextHopAddr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNextHopAddr;
    /// <include file='MIB_IPMCAST_OIF_STATS_LH.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_LH.dwDialContext"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDialContext;
    /// <include file='MIB_IPMCAST_OIF_STATS_LH.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_LH.ulTtlTooLow"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulTtlTooLow;
    /// <include file='MIB_IPMCAST_OIF_STATS_LH.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_LH.ulFragNeeded"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulFragNeeded;
    /// <include file='MIB_IPMCAST_OIF_STATS_LH.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_LH.ulOutPackets"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulOutPackets;
    /// <include file='MIB_IPMCAST_OIF_STATS_LH.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_LH.ulOutDiscards"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulOutDiscards;
}
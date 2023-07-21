// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_IPMCAST_OIF_STATS_W2K.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_W2K"]/*' />
public unsafe partial struct MIB_IPMCAST_OIF_STATS_W2K
{
    /// <include file='MIB_IPMCAST_OIF_STATS_W2K.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_W2K.dwOutIfIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutIfIndex;

    /// <include file='MIB_IPMCAST_OIF_STATS_W2K.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_W2K.dwNextHopAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNextHopAddr;

    /// <include file='MIB_IPMCAST_OIF_STATS_W2K.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_W2K.pvDialContext"]/*' />
    [NativeTypeName("PVOID")]
    public void* pvDialContext;

    /// <include file='MIB_IPMCAST_OIF_STATS_W2K.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_W2K.ulTtlTooLow"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulTtlTooLow;

    /// <include file='MIB_IPMCAST_OIF_STATS_W2K.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_W2K.ulFragNeeded"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulFragNeeded;

    /// <include file='MIB_IPMCAST_OIF_STATS_W2K.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_W2K.ulOutPackets"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulOutPackets;

    /// <include file='MIB_IPMCAST_OIF_STATS_W2K.xml' path='doc/member[@name="MIB_IPMCAST_OIF_STATS_W2K.ulOutDiscards"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulOutDiscards;
}

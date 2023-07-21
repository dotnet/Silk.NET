// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP"]/*' />
public partial struct MIB_IPMCAST_MFE_STATS_EX_XP
{
    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwGroup"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGroup;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwSource"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSource;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwSrcMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSrcMask;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwUpStrmNgbr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUpStrmNgbr;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwInIfIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInIfIndex;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwInIfProtocol"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInIfProtocol;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwRouteProtocol"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRouteProtocol;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwRouteNetwork"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRouteNetwork;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.dwRouteMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRouteMask;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulUpTime"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulUpTime;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulExpiryTime"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulExpiryTime;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulNumOutIf"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulNumOutIf;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulInPkts"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulInPkts;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulInOctets"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulInOctets;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulPktsDifferentIf"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulPktsDifferentIf;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulQueueOverflow"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulQueueOverflow;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulUninitMfe"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulUninitMfe;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulNegativeMfe"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulNegativeMfe;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulInDiscards"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulInDiscards;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulInHdrErrors"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulInHdrErrors;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.ulTotalOutPackets"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulTotalOutPackets;

    /// <include file='MIB_IPMCAST_MFE_STATS_EX_XP.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS_EX_XP.rgmiosOutStats"]/*' />
    [NativeTypeName("MIB_IPMCAST_OIF_STATS[1]")]
    public _rgmiosOutStats_e__FixedBuffer rgmiosOutStats;

    /// <include file='_rgmiosOutStats_e__FixedBuffer.xml' path='doc/member[@name="_rgmiosOutStats_e__FixedBuffer"]/*' />
    public partial struct _rgmiosOutStats_e__FixedBuffer
    {
        public MIB_IPMCAST_OIF_STATS_LH e0;

        [UnscopedRef]
        public ref MIB_IPMCAST_OIF_STATS_LH this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_IPMCAST_OIF_STATS_LH> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}

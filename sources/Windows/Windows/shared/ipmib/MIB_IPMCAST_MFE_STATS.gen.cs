// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS"]/*'/>
public partial struct MIB_IPMCAST_MFE_STATS
{
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwGroup"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwGroup;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwSource"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSource;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwSrcMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSrcMask;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwUpStrmNgbr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwUpStrmNgbr;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwInIfIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInIfIndex;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwInIfProtocol"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInIfProtocol;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwRouteProtocol"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRouteProtocol;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwRouteNetwork"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRouteNetwork;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.dwRouteMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRouteMask;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.ulUpTime"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulUpTime;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.ulExpiryTime"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulExpiryTime;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.ulNumOutIf"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulNumOutIf;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.ulInPkts"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulInPkts;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.ulInOctets"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulInOctets;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.ulPktsDifferentIf"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulPktsDifferentIf;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.ulQueueOverflow"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulQueueOverflow;
    /// <include file='MIB_IPMCAST_MFE_STATS.xml' path='doc/member[@name="MIB_IPMCAST_MFE_STATS.rgmiosOutStats"]/*'/>
    [NativeTypeName("MIB_IPMCAST_OIF_STATS[1]")]
    public _rgmiosOutStats_e__FixedBuffer rgmiosOutStats;
    /// <include file='_rgmiosOutStats_e__FixedBuffer.xml' path='doc/member[@name="_rgmiosOutStats_e__FixedBuffer"]/*'/>
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
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_IPMCAST_MFE_STATS_EX_XP
{
    [NativeTypeName("DWORD")]
    public uint dwGroup;

    [NativeTypeName("DWORD")]
    public uint dwSource;

    [NativeTypeName("DWORD")]
    public uint dwSrcMask;

    [NativeTypeName("DWORD")]
    public uint dwUpStrmNgbr;

    [NativeTypeName("DWORD")]
    public uint dwInIfIndex;

    [NativeTypeName("DWORD")]
    public uint dwInIfProtocol;

    [NativeTypeName("DWORD")]
    public uint dwRouteProtocol;

    [NativeTypeName("DWORD")]
    public uint dwRouteNetwork;

    [NativeTypeName("DWORD")]
    public uint dwRouteMask;

    [NativeTypeName("ULONG")]
    public uint ulUpTime;

    [NativeTypeName("ULONG")]
    public uint ulExpiryTime;

    [NativeTypeName("ULONG")]
    public uint ulNumOutIf;

    [NativeTypeName("ULONG")]
    public uint ulInPkts;

    [NativeTypeName("ULONG")]
    public uint ulInOctets;

    [NativeTypeName("ULONG")]
    public uint ulPktsDifferentIf;

    [NativeTypeName("ULONG")]
    public uint ulQueueOverflow;

    [NativeTypeName("ULONG")]
    public uint ulUninitMfe;

    [NativeTypeName("ULONG")]
    public uint ulNegativeMfe;

    [NativeTypeName("ULONG")]
    public uint ulInDiscards;

    [NativeTypeName("ULONG")]
    public uint ulInHdrErrors;

    [NativeTypeName("ULONG")]
    public uint ulTotalOutPackets;

    [NativeTypeName("MIB_IPMCAST_OIF_STATS[1]")]
    public _rgmiosOutStats_e__FixedBuffer rgmiosOutStats;

    public partial struct _rgmiosOutStats_e__FixedBuffer
    {
        public MIB_IPMCAST_OIF_STATS_LH e0;

        [UnscopedRef]
        public ref MIB_IPMCAST_OIF_STATS_LH this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_IPMCAST_OIF_STATS_LH> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}

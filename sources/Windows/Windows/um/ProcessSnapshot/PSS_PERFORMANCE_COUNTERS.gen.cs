// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct PSS_PERFORMANCE_COUNTERS
{
    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.TotalCycleCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TotalCycleCount;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.TotalWallClockPeriod"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TotalWallClockPeriod;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.VaCloneCycleCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VaCloneCycleCount;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.VaCloneWallClockPeriod"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VaCloneWallClockPeriod;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.VaSpaceCycleCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VaSpaceCycleCount;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.VaSpaceWallClockPeriod"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VaSpaceWallClockPeriod;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.AuxPagesCycleCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AuxPagesCycleCount;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.AuxPagesWallClockPeriod"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AuxPagesWallClockPeriod;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.HandlesCycleCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong HandlesCycleCount;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.HandlesWallClockPeriod"]/*' />
    [NativeTypeName("UINT64")]
    public ulong HandlesWallClockPeriod;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.ThreadsCycleCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ThreadsCycleCount;

    /// <include file='PSS_PERFORMANCE_COUNTERS.xml' path='doc/member[@name="PSS_PERFORMANCE_COUNTERS.ThreadsWallClockPeriod"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ThreadsWallClockPeriod;
}

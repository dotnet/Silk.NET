// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION"]/*'/>
public partial struct TXFS_QUERY_RM_INFORMATION
{
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.BytesRequired"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesRequired;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.TailLsn"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong TailLsn;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.CurrentLsn"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong CurrentLsn;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.ArchiveTailLsn"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ArchiveTailLsn;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LogContainerSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LogContainerSize;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.HighestVirtualClock"]/*'/>
    public LARGE_INTEGER HighestVirtualClock;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LogContainerCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogContainerCount;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LogContainerCountMax"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogContainerCountMax;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LogContainerCountMin"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogContainerCountMin;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LogGrowthIncrement"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogGrowthIncrement;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LogAutoShrinkPercentage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogAutoShrinkPercentage;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LoggingMode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LoggingMode;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.RmState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RmState;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LogCapacity"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LogCapacity;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.LogFree"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LogFree;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.TopsSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong TopsSize;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.TopsUsed"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong TopsUsed;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.TransactionCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong TransactionCount;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.OnePCCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong OnePCCount;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.TwoPCCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong TwoPCCount;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.NumberLogFileFull"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumberLogFileFull;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.OldestTransactionAge"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong OldestTransactionAge;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.RMName"]/*'/>
    public Guid RMName;
    /// <include file='TXFS_QUERY_RM_INFORMATION.xml' path='doc/member[@name="TXFS_QUERY_RM_INFORMATION.TmLogPathOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TmLogPathOffset;
}
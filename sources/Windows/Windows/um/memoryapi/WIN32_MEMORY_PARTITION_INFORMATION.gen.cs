// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION"]/*' />
public unsafe partial struct WIN32_MEMORY_PARTITION_INFORMATION
{
    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.NumaNode"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumaNode;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.Channel"]/*' />
    [NativeTypeName("ULONG")]
    public uint Channel;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.NumberOfNumaNodes"]/*' />
    [NativeTypeName("ULONG")]
    public uint NumberOfNumaNodes;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.ResidentAvailablePages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ResidentAvailablePages;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.CommittedPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CommittedPages;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.CommitLimit"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong CommitLimit;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.PeakCommitment"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong PeakCommitment;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.TotalNumberOfPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong TotalNumberOfPages;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.AvailablePages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong AvailablePages;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.ZeroPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ZeroPages;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.FreePages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong FreePages;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.StandbyPages"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong StandbyPages;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.Reserved"]/*' />
    [NativeTypeName("ULONG64[16]")]
    public fixed ulong Reserved[16];

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.MaximumCommitLimit"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong MaximumCommitLimit;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.Reserved2"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Reserved2;

    /// <include file='WIN32_MEMORY_PARTITION_INFORMATION.xml' path='doc/member[@name="WIN32_MEMORY_PARTITION_INFORMATION.PartitionId"]/*' />
    [NativeTypeName("ULONG")]
    public uint PartitionId;
}

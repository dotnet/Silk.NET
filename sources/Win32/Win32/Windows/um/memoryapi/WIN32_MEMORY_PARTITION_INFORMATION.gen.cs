// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WIN32_MEMORY_PARTITION_INFORMATION
{
    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("ULONG")]
    public uint NumaNode;

    [NativeTypeName("ULONG")]
    public uint Channel;

    [NativeTypeName("ULONG")]
    public uint NumberOfNumaNodes;

    [NativeTypeName("ULONG64")]
    public ulong ResidentAvailablePages;

    [NativeTypeName("ULONG64")]
    public ulong CommittedPages;

    [NativeTypeName("ULONG64")]
    public ulong CommitLimit;

    [NativeTypeName("ULONG64")]
    public ulong PeakCommitment;

    [NativeTypeName("ULONG64")]
    public ulong TotalNumberOfPages;

    [NativeTypeName("ULONG64")]
    public ulong AvailablePages;

    [NativeTypeName("ULONG64")]
    public ulong ZeroPages;

    [NativeTypeName("ULONG64")]
    public ulong FreePages;

    [NativeTypeName("ULONG64")]
    public ulong StandbyPages;

    [NativeTypeName("ULONG64[16]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("ULONG64")]
    public ulong MaximumCommitLimit;

    [NativeTypeName("ULONG64")]
    public ulong Reserved2;

    [NativeTypeName("ULONG")]
    public uint PartitionId;

    [InlineArray(16)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ulong e0;
    }
}

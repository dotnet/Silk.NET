// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TCP_ESTATS_PATH_ROD_v0
{
    [NativeTypeName("ULONG")]
    public uint FastRetran;

    [NativeTypeName("ULONG")]
    public uint Timeouts;

    [NativeTypeName("ULONG")]
    public uint SubsequentTimeouts;

    [NativeTypeName("ULONG")]
    public uint CurTimeoutCount;

    [NativeTypeName("ULONG")]
    public uint AbruptTimeouts;

    [NativeTypeName("ULONG")]
    public uint PktsRetrans;

    [NativeTypeName("ULONG")]
    public uint BytesRetrans;

    [NativeTypeName("ULONG")]
    public uint DupAcksIn;

    [NativeTypeName("ULONG")]
    public uint SacksRcvd;

    [NativeTypeName("ULONG")]
    public uint SackBlocksRcvd;

    [NativeTypeName("ULONG")]
    public uint CongSignals;

    [NativeTypeName("ULONG")]
    public uint PreCongSumCwnd;

    [NativeTypeName("ULONG")]
    public uint PreCongSumRtt;

    [NativeTypeName("ULONG")]
    public uint PostCongSumRtt;

    [NativeTypeName("ULONG")]
    public uint PostCongCountRtt;

    [NativeTypeName("ULONG")]
    public uint EcnSignals;

    [NativeTypeName("ULONG")]
    public uint EceRcvd;

    [NativeTypeName("ULONG")]
    public uint SendStall;

    [NativeTypeName("ULONG")]
    public uint QuenchRcvd;

    [NativeTypeName("ULONG")]
    public uint RetranThresh;

    [NativeTypeName("ULONG")]
    public uint SndDupAckEpisodes;

    [NativeTypeName("ULONG")]
    public uint SumBytesReordered;

    [NativeTypeName("ULONG")]
    public uint NonRecovDa;

    [NativeTypeName("ULONG")]
    public uint NonRecovDaEpisodes;

    [NativeTypeName("ULONG")]
    public uint AckAfterFr;

    [NativeTypeName("ULONG")]
    public uint DsackDups;

    [NativeTypeName("ULONG")]
    public uint SampleRtt;

    [NativeTypeName("ULONG")]
    public uint SmoothedRtt;

    [NativeTypeName("ULONG")]
    public uint RttVar;

    [NativeTypeName("ULONG")]
    public uint MaxRtt;

    [NativeTypeName("ULONG")]
    public uint MinRtt;

    [NativeTypeName("ULONG")]
    public uint SumRtt;

    [NativeTypeName("ULONG")]
    public uint CountRtt;

    [NativeTypeName("ULONG")]
    public uint CurRto;

    [NativeTypeName("ULONG")]
    public uint MaxRto;

    [NativeTypeName("ULONG")]
    public uint MinRto;

    [NativeTypeName("ULONG")]
    public uint CurMss;

    [NativeTypeName("ULONG")]
    public uint MaxMss;

    [NativeTypeName("ULONG")]
    public uint MinMss;

    [NativeTypeName("ULONG")]
    public uint SpuriousRtoDetections;
}

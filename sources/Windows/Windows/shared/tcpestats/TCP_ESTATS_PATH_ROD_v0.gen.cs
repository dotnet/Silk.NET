// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0"]/*'/>
public partial struct TCP_ESTATS_PATH_ROD_v0
{
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.FastRetran"]/*'/>
    [NativeTypeName("ULONG")]
    public uint FastRetran;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.Timeouts"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Timeouts;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SubsequentTimeouts"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SubsequentTimeouts;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.CurTimeoutCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CurTimeoutCount;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.AbruptTimeouts"]/*'/>
    [NativeTypeName("ULONG")]
    public uint AbruptTimeouts;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.PktsRetrans"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PktsRetrans;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.BytesRetrans"]/*'/>
    [NativeTypeName("ULONG")]
    public uint BytesRetrans;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.DupAcksIn"]/*'/>
    [NativeTypeName("ULONG")]
    public uint DupAcksIn;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SacksRcvd"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SacksRcvd;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SackBlocksRcvd"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SackBlocksRcvd;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.CongSignals"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CongSignals;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.PreCongSumCwnd"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PreCongSumCwnd;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.PreCongSumRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PreCongSumRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.PostCongSumRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PostCongSumRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.PostCongCountRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PostCongCountRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.EcnSignals"]/*'/>
    [NativeTypeName("ULONG")]
    public uint EcnSignals;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.EceRcvd"]/*'/>
    [NativeTypeName("ULONG")]
    public uint EceRcvd;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SendStall"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SendStall;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.QuenchRcvd"]/*'/>
    [NativeTypeName("ULONG")]
    public uint QuenchRcvd;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.RetranThresh"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RetranThresh;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SndDupAckEpisodes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SndDupAckEpisodes;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SumBytesReordered"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SumBytesReordered;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.NonRecovDa"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NonRecovDa;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.NonRecovDaEpisodes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NonRecovDaEpisodes;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.AckAfterFr"]/*'/>
    [NativeTypeName("ULONG")]
    public uint AckAfterFr;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.DsackDups"]/*'/>
    [NativeTypeName("ULONG")]
    public uint DsackDups;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SampleRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SampleRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SmoothedRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SmoothedRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.RttVar"]/*'/>
    [NativeTypeName("ULONG")]
    public uint RttVar;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.MaxRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaxRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.MinRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MinRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SumRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SumRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.CountRtt"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CountRtt;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.CurRto"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CurRto;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.MaxRto"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaxRto;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.MinRto"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MinRto;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.CurMss"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CurMss;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.MaxMss"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaxMss;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.MinMss"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MinMss;
    /// <include file='TCP_ESTATS_PATH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_PATH_ROD_v0.SpuriousRtoDetections"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SpuriousRtoDetections;
}
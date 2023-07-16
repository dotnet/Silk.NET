// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS"]/*'/>
public partial struct COMPOSITION_TARGET_STATS
{
    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.outstandingPresents"]/*'/>
    public uint outstandingPresents;
    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.presentTime"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong presentTime;
    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.vblankDuration"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong vblankDuration;
    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.presentedStats"]/*'/>
    public COMPOSITION_STATS presentedStats;
    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.completedStats"]/*'/>
    public COMPOSITION_STATS completedStats;
}
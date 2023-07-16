// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='COMPOSITION_FRAME_STATS.xml' path='doc/member[@name="COMPOSITION_FRAME_STATS"]/*'/>
public partial struct COMPOSITION_FRAME_STATS
{
    /// <include file='COMPOSITION_FRAME_STATS.xml' path='doc/member[@name="COMPOSITION_FRAME_STATS.startTime"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong startTime;
    /// <include file='COMPOSITION_FRAME_STATS.xml' path='doc/member[@name="COMPOSITION_FRAME_STATS.targetTime"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong targetTime;
    /// <include file='COMPOSITION_FRAME_STATS.xml' path='doc/member[@name="COMPOSITION_FRAME_STATS.framePeriod"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong framePeriod;
}
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='COMPOSITION_STATS.xml' path='doc/member[@name="COMPOSITION_STATS"]/*'/>
public partial struct COMPOSITION_STATS
{
    /// <include file='COMPOSITION_STATS.xml' path='doc/member[@name="COMPOSITION_STATS.presentCount"]/*'/>
    public uint presentCount;
    /// <include file='COMPOSITION_STATS.xml' path='doc/member[@name="COMPOSITION_STATS.refreshCount"]/*'/>
    public uint refreshCount;
    /// <include file='COMPOSITION_STATS.xml' path='doc/member[@name="COMPOSITION_STATS.virtualRefreshCount"]/*'/>
    public uint virtualRefreshCount;
    /// <include file='COMPOSITION_STATS.xml' path='doc/member[@name="COMPOSITION_STATS.time"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong time;
}
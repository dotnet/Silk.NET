// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NL_PATH_BANDWIDTH_ROD.xml' path='doc/member[@name="NL_PATH_BANDWIDTH_ROD"]/*'/>
public partial struct NL_PATH_BANDWIDTH_ROD
{
    /// <include file='NL_PATH_BANDWIDTH_ROD.xml' path='doc/member[@name="NL_PATH_BANDWIDTH_ROD.Bandwidth"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong Bandwidth;
    /// <include file='NL_PATH_BANDWIDTH_ROD.xml' path='doc/member[@name="NL_PATH_BANDWIDTH_ROD.Instability"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong Instability;
    /// <include file='NL_PATH_BANDWIDTH_ROD.xml' path='doc/member[@name="NL_PATH_BANDWIDTH_ROD.BandwidthPeaked"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte BandwidthPeaked;
}
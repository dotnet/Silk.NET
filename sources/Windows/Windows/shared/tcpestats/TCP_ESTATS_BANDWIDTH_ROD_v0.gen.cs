// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TCP_ESTATS_BANDWIDTH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_BANDWIDTH_ROD_v0"]/*'/>
public partial struct TCP_ESTATS_BANDWIDTH_ROD_v0
{
    /// <include file='TCP_ESTATS_BANDWIDTH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_BANDWIDTH_ROD_v0.OutboundBandwidth"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong OutboundBandwidth;
    /// <include file='TCP_ESTATS_BANDWIDTH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_BANDWIDTH_ROD_v0.InboundBandwidth"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong InboundBandwidth;
    /// <include file='TCP_ESTATS_BANDWIDTH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_BANDWIDTH_ROD_v0.OutboundInstability"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong OutboundInstability;
    /// <include file='TCP_ESTATS_BANDWIDTH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_BANDWIDTH_ROD_v0.InboundInstability"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong InboundInstability;
    /// <include file='TCP_ESTATS_BANDWIDTH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_BANDWIDTH_ROD_v0.OutboundBandwidthPeaked"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte OutboundBandwidthPeaked;
    /// <include file='TCP_ESTATS_BANDWIDTH_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_BANDWIDTH_ROD_v0.InboundBandwidthPeaked"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte InboundBandwidthPeaked;
}
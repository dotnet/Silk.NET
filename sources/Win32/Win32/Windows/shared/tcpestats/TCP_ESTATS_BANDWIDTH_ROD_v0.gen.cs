// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TCP_ESTATS_BANDWIDTH_ROD_v0
{
    [NativeTypeName("ULONG64")]
    public ulong OutboundBandwidth;

    [NativeTypeName("ULONG64")]
    public ulong InboundBandwidth;

    [NativeTypeName("ULONG64")]
    public ulong OutboundInstability;

    [NativeTypeName("ULONG64")]
    public ulong InboundInstability;

    [NativeTypeName("BOOLEAN")]
    public byte OutboundBandwidthPeaked;

    [NativeTypeName("BOOLEAN")]
    public byte InboundBandwidthPeaked;
}

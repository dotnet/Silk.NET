// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.22621.0")]
public partial struct INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES
{
    [NativeTypeName("BOOLEAN")]
    public byte PtpV2OverUdpIPv4EventMessageReceive;

    [NativeTypeName("BOOLEAN")]
    public byte PtpV2OverUdpIPv4AllMessageReceive;

    [NativeTypeName("BOOLEAN")]
    public byte PtpV2OverUdpIPv4EventMessageTransmit;

    [NativeTypeName("BOOLEAN")]
    public byte PtpV2OverUdpIPv4AllMessageTransmit;

    [NativeTypeName("BOOLEAN")]
    public byte PtpV2OverUdpIPv6EventMessageReceive;

    [NativeTypeName("BOOLEAN")]
    public byte PtpV2OverUdpIPv6AllMessageReceive;

    [NativeTypeName("BOOLEAN")]
    public byte PtpV2OverUdpIPv6EventMessageTransmit;

    [NativeTypeName("BOOLEAN")]
    public byte PtpV2OverUdpIPv6AllMessageTransmit;

    [NativeTypeName("BOOLEAN")]
    public byte AllReceive;

    [NativeTypeName("BOOLEAN")]
    public byte AllTransmit;

    [NativeTypeName("BOOLEAN")]
    public byte TaggedTransmit;
}

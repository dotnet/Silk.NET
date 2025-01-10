// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct WCM_DATAPLAN_STATUS
{
    public WCM_USAGE_DATA UsageData;

    [NativeTypeName("DWORD")]
    public uint DataLimitInMegabytes;

    [NativeTypeName("DWORD")]
    public uint InboundBandwidthInKbps;

    [NativeTypeName("DWORD")]
    public uint OutboundBandwidthInKbps;
    public WCM_BILLING_CYCLE_INFO BillingCycle;

    [NativeTypeName("DWORD")]
    public uint MaxTransferSizeInMegabytes;

    [NativeTypeName("DWORD")]
    public uint Reserved;
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WCM_DATAPLAN_STATUS.xml' path='doc/member[@name="WCM_DATAPLAN_STATUS"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct WCM_DATAPLAN_STATUS
{
    /// <include file='WCM_DATAPLAN_STATUS.xml' path='doc/member[@name="WCM_DATAPLAN_STATUS.UsageData"]/*' />
    public WCM_USAGE_DATA UsageData;

    /// <include file='WCM_DATAPLAN_STATUS.xml' path='doc/member[@name="WCM_DATAPLAN_STATUS.DataLimitInMegabytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataLimitInMegabytes;

    /// <include file='WCM_DATAPLAN_STATUS.xml' path='doc/member[@name="WCM_DATAPLAN_STATUS.InboundBandwidthInKbps"]/*' />
    [NativeTypeName("DWORD")]
    public uint InboundBandwidthInKbps;

    /// <include file='WCM_DATAPLAN_STATUS.xml' path='doc/member[@name="WCM_DATAPLAN_STATUS.OutboundBandwidthInKbps"]/*' />
    [NativeTypeName("DWORD")]
    public uint OutboundBandwidthInKbps;

    /// <include file='WCM_DATAPLAN_STATUS.xml' path='doc/member[@name="WCM_DATAPLAN_STATUS.BillingCycle"]/*' />
    public WCM_BILLING_CYCLE_INFO BillingCycle;

    /// <include file='WCM_DATAPLAN_STATUS.xml' path='doc/member[@name="WCM_DATAPLAN_STATUS.MaxTransferSizeInMegabytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTransferSizeInMegabytes;

    /// <include file='WCM_DATAPLAN_STATUS.xml' path='doc/member[@name="WCM_DATAPLAN_STATUS.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;
}

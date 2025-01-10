// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NDIS_INTERFACE_INFORMATION
{
    public NET_IF_OPER_STATUS ifOperStatus;

    [NativeTypeName("ULONG")]
    public uint ifOperStatusFlags;
    public NET_IF_MEDIA_CONNECT_STATE MediaConnectState;
    public NET_IF_MEDIA_DUPLEX_STATE MediaDuplexState;

    [NativeTypeName("ULONG")]
    public uint ifMtu;

    [NativeTypeName("BOOLEAN")]
    public byte ifPromiscuousMode;

    [NativeTypeName("BOOLEAN")]
    public byte ifDeviceWakeUpEnable;

    [NativeTypeName("ULONG64")]
    public ulong XmitLinkSpeed;

    [NativeTypeName("ULONG64")]
    public ulong RcvLinkSpeed;

    [NativeTypeName("ULONG64")]
    public ulong ifLastChange;

    [NativeTypeName("ULONG64")]
    public ulong ifCounterDiscontinuityTime;

    [NativeTypeName("ULONG64")]
    public ulong ifInUnknownProtos;

    [NativeTypeName("ULONG64")]
    public ulong ifInDiscards;

    [NativeTypeName("ULONG64")]
    public ulong ifInErrors;

    [NativeTypeName("ULONG64")]
    public ulong ifHCInOctets;

    [NativeTypeName("ULONG64")]
    public ulong ifHCInUcastPkts;

    [NativeTypeName("ULONG64")]
    public ulong ifHCInMulticastPkts;

    [NativeTypeName("ULONG64")]
    public ulong ifHCInBroadcastPkts;

    [NativeTypeName("ULONG64")]
    public ulong ifHCOutOctets;

    [NativeTypeName("ULONG64")]
    public ulong ifHCOutUcastPkts;

    [NativeTypeName("ULONG64")]
    public ulong ifHCOutMulticastPkts;

    [NativeTypeName("ULONG64")]
    public ulong ifHCOutBroadcastPkts;

    [NativeTypeName("ULONG64")]
    public ulong ifOutErrors;

    [NativeTypeName("ULONG64")]
    public ulong ifOutDiscards;

    [NativeTypeName("ULONG64")]
    public ulong ifHCInUcastOctets;

    [NativeTypeName("ULONG64")]
    public ulong ifHCInMulticastOctets;

    [NativeTypeName("ULONG64")]
    public ulong ifHCInBroadcastOctets;

    [NativeTypeName("ULONG64")]
    public ulong ifHCOutUcastOctets;

    [NativeTypeName("ULONG64")]
    public ulong ifHCOutMulticastOctets;

    [NativeTypeName("ULONG64")]
    public ulong ifHCOutBroadcastOctets;

    [NativeTypeName("NET_IF_COMPARTMENT_ID")]
    public uint CompartmentId;

    [NativeTypeName("ULONG")]
    public uint SupportedStatistics;
}

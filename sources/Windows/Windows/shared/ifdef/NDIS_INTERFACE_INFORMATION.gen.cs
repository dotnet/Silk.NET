// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION"]/*'/>
public partial struct NDIS_INTERFACE_INFORMATION
{
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifOperStatus"]/*'/>
    public NET_IF_OPER_STATUS ifOperStatus;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifOperStatusFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ifOperStatusFlags;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.MediaConnectState"]/*'/>
    public NET_IF_MEDIA_CONNECT_STATE MediaConnectState;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.MediaDuplexState"]/*'/>
    public NET_IF_MEDIA_DUPLEX_STATE MediaDuplexState;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifMtu"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ifMtu;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifPromiscuousMode"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ifPromiscuousMode;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifDeviceWakeUpEnable"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ifDeviceWakeUpEnable;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.XmitLinkSpeed"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong XmitLinkSpeed;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.RcvLinkSpeed"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong RcvLinkSpeed;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifLastChange"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifLastChange;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifCounterDiscontinuityTime"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifCounterDiscontinuityTime;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifInUnknownProtos"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifInUnknownProtos;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifInDiscards"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifInDiscards;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifInErrors"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifInErrors;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCInOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCInOctets;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCInUcastPkts"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCInUcastPkts;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCInMulticastPkts"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCInMulticastPkts;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCInBroadcastPkts"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCInBroadcastPkts;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCOutOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCOutOctets;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCOutUcastPkts"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCOutUcastPkts;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCOutMulticastPkts"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCOutMulticastPkts;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCOutBroadcastPkts"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCOutBroadcastPkts;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifOutErrors"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifOutErrors;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifOutDiscards"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifOutDiscards;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCInUcastOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCInUcastOctets;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCInMulticastOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCInMulticastOctets;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCInBroadcastOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCInBroadcastOctets;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCOutUcastOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCOutUcastOctets;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCOutMulticastOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCOutMulticastOctets;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.ifHCOutBroadcastOctets"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ifHCOutBroadcastOctets;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.CompartmentId"]/*'/>
    [NativeTypeName("NET_IF_COMPARTMENT_ID")]
    public uint CompartmentId;
    /// <include file='NDIS_INTERFACE_INFORMATION.xml' path='doc/member[@name="NDIS_INTERFACE_INFORMATION.SupportedStatistics"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SupportedStatistics;
}
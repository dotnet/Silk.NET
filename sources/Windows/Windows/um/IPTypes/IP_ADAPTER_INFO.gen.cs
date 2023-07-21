// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO"]/*' />
public unsafe partial struct IP_ADAPTER_INFO
{
    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.Next"]/*' />
    [NativeTypeName("struct _IP_ADAPTER_INFO *")]
    public IP_ADAPTER_INFO* Next;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.ComboIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint ComboIndex;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.AdapterName"]/*' />
    [NativeTypeName("char[260]")]
    public fixed sbyte AdapterName[260];

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.Description"]/*' />
    [NativeTypeName("char[132]")]
    public fixed sbyte Description[132];

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.AddressLength"]/*' />
    public uint AddressLength;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.Address"]/*' />
    [NativeTypeName("BYTE[8]")]
    public fixed byte Address[8];

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.Index"]/*' />
    [NativeTypeName("DWORD")]
    public uint Index;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.Type"]/*' />
    public uint Type;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.DhcpEnabled"]/*' />
    public uint DhcpEnabled;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.CurrentIpAddress"]/*' />
    [NativeTypeName("PIP_ADDR_STRING")]
    public IP_ADDR_STRING* CurrentIpAddress;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.IpAddressList"]/*' />
    public IP_ADDR_STRING IpAddressList;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.GatewayList"]/*' />
    public IP_ADDR_STRING GatewayList;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.DhcpServer"]/*' />
    public IP_ADDR_STRING DhcpServer;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.HaveWins"]/*' />
    public BOOL HaveWins;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.PrimaryWinsServer"]/*' />
    public IP_ADDR_STRING PrimaryWinsServer;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.SecondaryWinsServer"]/*' />
    public IP_ADDR_STRING SecondaryWinsServer;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.LeaseObtained"]/*' />
    [NativeTypeName("time_t")]
    public long LeaseObtained;

    /// <include file='IP_ADAPTER_INFO.xml' path='doc/member[@name="IP_ADAPTER_INFO.LeaseExpires"]/*' />
    [NativeTypeName("time_t")]
    public long LeaseExpires;
}

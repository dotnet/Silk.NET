// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct IP_ADAPTER_INFO
{
    [NativeTypeName("struct _IP_ADAPTER_INFO *")]
    public IP_ADAPTER_INFO* Next;

    [NativeTypeName("DWORD")]
    public uint ComboIndex;

    [NativeTypeName("char[260]")]
    public _AdapterName_e__FixedBuffer AdapterName;

    [NativeTypeName("char[132]")]
    public _Description_e__FixedBuffer Description;
    public uint AddressLength;

    [NativeTypeName("BYTE[8]")]
    public _Address_e__FixedBuffer Address;

    [NativeTypeName("DWORD")]
    public uint Index;
    public uint Type;
    public uint DhcpEnabled;

    [NativeTypeName("PIP_ADDR_STRING")]
    public IP_ADDR_STRING* CurrentIpAddress;
    public IP_ADDR_STRING IpAddressList;
    public IP_ADDR_STRING GatewayList;
    public IP_ADDR_STRING DhcpServer;
    public BOOL HaveWins;
    public IP_ADDR_STRING PrimaryWinsServer;
    public IP_ADDR_STRING SecondaryWinsServer;

    [NativeTypeName("time_t")]
    public long LeaseObtained;

    [NativeTypeName("time_t")]
    public long LeaseExpires;

    [InlineArray(260)]
    public partial struct _AdapterName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(132)]
    public partial struct _Description_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(8)]
    public partial struct _Address_e__FixedBuffer
    {
        public byte e0;
    }
}

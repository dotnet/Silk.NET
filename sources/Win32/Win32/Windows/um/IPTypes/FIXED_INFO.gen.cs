// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct FIXED_INFO
{
    [NativeTypeName("char[132]")]
    public _HostName_e__FixedBuffer HostName;

    [NativeTypeName("char[132]")]
    public _DomainName_e__FixedBuffer DomainName;

    [NativeTypeName("PIP_ADDR_STRING")]
    public IP_ADDR_STRING* CurrentDnsServer;
    public IP_ADDR_STRING DnsServerList;
    public uint NodeType;

    [NativeTypeName("char[260]")]
    public _ScopeId_e__FixedBuffer ScopeId;
    public uint EnableRouting;
    public uint EnableProxy;
    public uint EnableDns;

    [InlineArray(132)]
    public partial struct _HostName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(132)]
    public partial struct _DomainName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(260)]
    public partial struct _ScopeId_e__FixedBuffer
    {
        public sbyte e0;
    }
}

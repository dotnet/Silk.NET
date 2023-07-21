// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IP_PER_ADAPTER_INFO_W2KSP1.xml' path='doc/member[@name="IP_PER_ADAPTER_INFO_W2KSP1"]/*' />
public unsafe partial struct IP_PER_ADAPTER_INFO_W2KSP1
{
    /// <include file='IP_PER_ADAPTER_INFO_W2KSP1.xml' path='doc/member[@name="IP_PER_ADAPTER_INFO_W2KSP1.AutoconfigEnabled"]/*' />
    public uint AutoconfigEnabled;

    /// <include file='IP_PER_ADAPTER_INFO_W2KSP1.xml' path='doc/member[@name="IP_PER_ADAPTER_INFO_W2KSP1.AutoconfigActive"]/*' />
    public uint AutoconfigActive;

    /// <include file='IP_PER_ADAPTER_INFO_W2KSP1.xml' path='doc/member[@name="IP_PER_ADAPTER_INFO_W2KSP1.CurrentDnsServer"]/*' />
    [NativeTypeName("PIP_ADDR_STRING")]
    public IP_ADDR_STRING* CurrentDnsServer;

    /// <include file='IP_PER_ADAPTER_INFO_W2KSP1.xml' path='doc/member[@name="IP_PER_ADAPTER_INFO_W2KSP1.DnsServerList"]/*' />
    public IP_ADDR_STRING DnsServerList;
}

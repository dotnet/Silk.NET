// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='INTERFACE_INFO_EX.xml' path='doc/member[@name="INTERFACE_INFO_EX"]/*' />
public partial struct INTERFACE_INFO_EX
{
    /// <include file='INTERFACE_INFO_EX.xml' path='doc/member[@name="INTERFACE_INFO_EX.iiFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint iiFlags;

    /// <include file='INTERFACE_INFO_EX.xml' path='doc/member[@name="INTERFACE_INFO_EX.iiAddress"]/*' />
    public SOCKET_ADDRESS iiAddress;

    /// <include file='INTERFACE_INFO_EX.xml' path='doc/member[@name="INTERFACE_INFO_EX.iiBroadcastAddress"]/*' />
    public SOCKET_ADDRESS iiBroadcastAddress;

    /// <include file='INTERFACE_INFO_EX.xml' path='doc/member[@name="INTERFACE_INFO_EX.iiNetmask"]/*' />
    public SOCKET_ADDRESS iiNetmask;
}

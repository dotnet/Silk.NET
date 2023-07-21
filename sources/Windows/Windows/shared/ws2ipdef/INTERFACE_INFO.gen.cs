// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='INTERFACE_INFO.xml' path='doc/member[@name="INTERFACE_INFO"]/*' />
public partial struct INTERFACE_INFO
{
    /// <include file='INTERFACE_INFO.xml' path='doc/member[@name="INTERFACE_INFO.iiFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint iiFlags;

    /// <include file='INTERFACE_INFO.xml' path='doc/member[@name="INTERFACE_INFO.iiAddress"]/*' />
    public sockaddr_gen iiAddress;

    /// <include file='INTERFACE_INFO.xml' path='doc/member[@name="INTERFACE_INFO.iiBroadcastAddress"]/*' />
    public sockaddr_gen iiBroadcastAddress;

    /// <include file='INTERFACE_INFO.xml' path='doc/member[@name="INTERFACE_INFO.iiNetmask"]/*' />
    public sockaddr_gen iiNetmask;
}

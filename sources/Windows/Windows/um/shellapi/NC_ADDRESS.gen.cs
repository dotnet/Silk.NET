// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NC_ADDRESS.xml' path='doc/member[@name="NC_ADDRESS"]/*' />
public unsafe partial struct NC_ADDRESS
{
    /// <include file='NC_ADDRESS.xml' path='doc/member[@name="NC_ADDRESS.pAddrInfo"]/*' />
    [NativeTypeName("struct NET_ADDRESS_INFO_ *")]
    public NET_ADDRESS_INFO* pAddrInfo;

    /// <include file='NC_ADDRESS.xml' path='doc/member[@name="NC_ADDRESS.PortNumber"]/*' />
    public ushort PortNumber;

    /// <include file='NC_ADDRESS.xml' path='doc/member[@name="NC_ADDRESS.PrefixLength"]/*' />
    public byte PrefixLength;
}

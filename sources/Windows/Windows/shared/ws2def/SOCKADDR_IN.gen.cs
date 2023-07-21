// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SOCKADDR_IN.xml' path='doc/member[@name="SOCKADDR_IN"]/*' />
public unsafe partial struct SOCKADDR_IN
{
    /// <include file='SOCKADDR_IN.xml' path='doc/member[@name="SOCKADDR_IN.sin_family"]/*' />
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sin_family;

    /// <include file='SOCKADDR_IN.xml' path='doc/member[@name="SOCKADDR_IN.sin_port"]/*' />
    public ushort sin_port;

    /// <include file='SOCKADDR_IN.xml' path='doc/member[@name="SOCKADDR_IN.sin_addr"]/*' />
    public IN_ADDR sin_addr;

    /// <include file='SOCKADDR_IN.xml' path='doc/member[@name="SOCKADDR_IN.sin_zero"]/*' />
    [NativeTypeName("CHAR[8]")]
    public fixed sbyte sin_zero[8];
}

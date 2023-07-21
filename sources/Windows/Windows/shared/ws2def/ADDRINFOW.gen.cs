// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW"]/*' />
public unsafe partial struct ADDRINFOW
{
    /// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW.ai_flags"]/*' />
    public int ai_flags;

    /// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW.ai_family"]/*' />
    public int ai_family;

    /// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW.ai_socktype"]/*' />
    public int ai_socktype;

    /// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW.ai_protocol"]/*' />
    public int ai_protocol;

    /// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW.ai_addrlen"]/*' />
    [NativeTypeName("size_t")]
    public nuint ai_addrlen;

    /// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW.ai_canonname"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* ai_canonname;

    /// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW.ai_addr"]/*' />
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;

    /// <include file='ADDRINFOW.xml' path='doc/member[@name="ADDRINFOW.ai_next"]/*' />
    [NativeTypeName("struct addrinfoW *")]
    public ADDRINFOW* ai_next;
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='sockaddr_gen.xml' path='doc/member[@name="sockaddr_gen"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct sockaddr_gen
{
    /// <include file='sockaddr_gen.xml' path='doc/member[@name="sockaddr_gen.Address"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct sockaddr")]
    public SOCKADDR Address;

    /// <include file='sockaddr_gen.xml' path='doc/member[@name="sockaddr_gen.AddressIn"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct sockaddr_in")]
    public SOCKADDR_IN AddressIn;

    /// <include file='sockaddr_gen.xml' path='doc/member[@name="sockaddr_gen.AddressIn6"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct sockaddr_in6_old")]
    public sockaddr_in6_old AddressIn6;
}

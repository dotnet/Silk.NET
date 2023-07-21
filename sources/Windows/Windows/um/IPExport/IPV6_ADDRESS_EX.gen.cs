// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct IPV6_ADDRESS_EX
{
    /// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX.sin6_port"]/*' />
    public ushort sin6_port;

    /// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX.sin6_flowinfo"]/*' />
    [NativeTypeName("ULONG")]
    public uint sin6_flowinfo;

    /// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX.sin6_addr"]/*' />
    [NativeTypeName("USHORT[8]")]
    public fixed ushort sin6_addr[8];

    /// <include file='IPV6_ADDRESS_EX.xml' path='doc/member[@name="IPV6_ADDRESS_EX.sin6_scope_id"]/*' />
    [NativeTypeName("ULONG")]
    public uint sin6_scope_id;
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KERB_NET_ADDRESS.xml' path='doc/member[@name="KERB_NET_ADDRESS"]/*' />
public unsafe partial struct KERB_NET_ADDRESS
{
    /// <include file='KERB_NET_ADDRESS.xml' path='doc/member[@name="KERB_NET_ADDRESS.Family"]/*' />
    [NativeTypeName("ULONG")]
    public uint Family;

    /// <include file='KERB_NET_ADDRESS.xml' path='doc/member[@name="KERB_NET_ADDRESS.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='KERB_NET_ADDRESS.xml' path='doc/member[@name="KERB_NET_ADDRESS.Address"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* Address;
}

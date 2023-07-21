// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION"]/*' />
public unsafe partial struct SEND_GENERIC_TLS_EXTENSION
{
    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.ExtensionType"]/*' />
    [NativeTypeName("WORD")]
    public ushort ExtensionType;

    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.HandshakeType"]/*' />
    [NativeTypeName("WORD")]
    public ushort HandshakeType;

    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.BufferSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort BufferSize;

    /// <include file='SEND_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SEND_GENERIC_TLS_EXTENSION.Buffer"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public fixed byte Buffer[1];
}

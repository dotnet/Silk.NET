// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_EXTENSIONS.xml' path='doc/member[@name="CERT_EXTENSIONS"]/*' />
public unsafe partial struct CERT_EXTENSIONS
{
    /// <include file='CERT_EXTENSIONS.xml' path='doc/member[@name="CERT_EXTENSIONS.cExtension"]/*' />
    [NativeTypeName("DWORD")]
    public uint cExtension;

    /// <include file='CERT_EXTENSIONS.xml' path='doc/member[@name="CERT_EXTENSIONS.rgExtension"]/*' />
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}

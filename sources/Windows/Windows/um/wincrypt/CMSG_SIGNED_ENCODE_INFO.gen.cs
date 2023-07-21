// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CMSG_SIGNED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNED_ENCODE_INFO"]/*' />
public unsafe partial struct CMSG_SIGNED_ENCODE_INFO
{
    /// <include file='CMSG_SIGNED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNED_ENCODE_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMSG_SIGNED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNED_ENCODE_INFO.cSigners"]/*' />
    [NativeTypeName("DWORD")]
    public uint cSigners;

    /// <include file='CMSG_SIGNED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNED_ENCODE_INFO.rgSigners"]/*' />
    [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")]
    public CMSG_SIGNER_ENCODE_INFO* rgSigners;

    /// <include file='CMSG_SIGNED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNED_ENCODE_INFO.cCertEncoded"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCertEncoded;

    /// <include file='CMSG_SIGNED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNED_ENCODE_INFO.rgCertEncoded"]/*' />
    [NativeTypeName("PCERT_BLOB")]
    public CRYPT_DATA_BLOB* rgCertEncoded;

    /// <include file='CMSG_SIGNED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNED_ENCODE_INFO.cCrlEncoded"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCrlEncoded;

    /// <include file='CMSG_SIGNED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_SIGNED_ENCODE_INFO.rgCrlEncoded"]/*' />
    [NativeTypeName("PCRL_BLOB")]
    public CRYPT_DATA_BLOB* rgCrlEncoded;
}

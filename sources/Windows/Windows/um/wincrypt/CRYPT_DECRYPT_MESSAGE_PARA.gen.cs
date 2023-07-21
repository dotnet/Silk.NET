// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_DECRYPT_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_DECRYPT_MESSAGE_PARA"]/*' />
public unsafe partial struct CRYPT_DECRYPT_MESSAGE_PARA
{
    /// <include file='CRYPT_DECRYPT_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_DECRYPT_MESSAGE_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CRYPT_DECRYPT_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_DECRYPT_MESSAGE_PARA.dwMsgAndCertEncodingType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMsgAndCertEncodingType;

    /// <include file='CRYPT_DECRYPT_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_DECRYPT_MESSAGE_PARA.cCertStore"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCertStore;

    /// <include file='CRYPT_DECRYPT_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_DECRYPT_MESSAGE_PARA.rghCertStore"]/*' />
    public HCERTSTORE* rghCertStore;
}

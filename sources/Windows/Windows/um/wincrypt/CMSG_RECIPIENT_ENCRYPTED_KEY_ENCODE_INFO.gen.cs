// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO"]/*' />
public unsafe partial struct CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO
{
    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.RecipientPublicKey"]/*' />
    public CRYPT_BIT_BLOB RecipientPublicKey;

    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.RecipientId"]/*' />
    public CERT_ID RecipientId;

    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.Date"]/*' />
    public FILETIME Date;

    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO.pOtherAttr"]/*' />
    [NativeTypeName("PCRYPT_ATTRIBUTE_TYPE_VALUE")]
    public CRYPT_ATTRIBUTE_TYPE_VALUE* pOtherAttr;
}

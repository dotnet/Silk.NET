// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_INFO"]/*'/>
public unsafe partial struct CMSG_RECIPIENT_ENCRYPTED_KEY_INFO
{
    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.RecipientId"]/*'/>
    public CERT_ID RecipientId;
    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.EncryptedKey"]/*'/>
    public CRYPT_DATA_BLOB EncryptedKey;
    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.Date"]/*'/>
    public FILETIME Date;
    /// <include file='CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.xml' path='doc/member[@name="CMSG_RECIPIENT_ENCRYPTED_KEY_INFO.pOtherAttr"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE_TYPE_VALUE")]
    public CRYPT_ATTRIBUTE_TYPE_VALUE* pOtherAttr;
}
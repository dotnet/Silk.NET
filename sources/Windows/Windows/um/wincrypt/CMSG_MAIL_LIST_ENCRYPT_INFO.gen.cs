// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMSG_MAIL_LIST_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_ENCRYPT_INFO"]/*'/>
public partial struct CMSG_MAIL_LIST_ENCRYPT_INFO
{
    /// <include file='CMSG_MAIL_LIST_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_ENCRYPT_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_MAIL_LIST_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_ENCRYPT_INFO.dwRecipientIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRecipientIndex;
    /// <include file='CMSG_MAIL_LIST_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_ENCRYPT_INFO.KeyEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;
    /// <include file='CMSG_MAIL_LIST_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_ENCRYPT_INFO.EncryptedKey"]/*'/>
    public CRYPT_DATA_BLOB EncryptedKey;
    /// <include file='CMSG_MAIL_LIST_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_ENCRYPT_INFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
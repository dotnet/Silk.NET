// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMSG_KEY_TRANS_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_TRANS_RECIPIENT_INFO"]/*'/>
public partial struct CMSG_KEY_TRANS_RECIPIENT_INFO
{
    /// <include file='CMSG_KEY_TRANS_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_TRANS_RECIPIENT_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CMSG_KEY_TRANS_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_TRANS_RECIPIENT_INFO.RecipientId"]/*'/>
    public CERT_ID RecipientId;
    /// <include file='CMSG_KEY_TRANS_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_TRANS_RECIPIENT_INFO.KeyEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;
    /// <include file='CMSG_KEY_TRANS_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_KEY_TRANS_RECIPIENT_INFO.EncryptedKey"]/*'/>
    public CRYPT_DATA_BLOB EncryptedKey;
}
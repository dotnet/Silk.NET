// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_ENCRYPTED_PRIVATE_KEY_INFO.xml' path='doc/member[@name="CRYPT_ENCRYPTED_PRIVATE_KEY_INFO"]/*'/>
public partial struct CRYPT_ENCRYPTED_PRIVATE_KEY_INFO
{
    /// <include file='CRYPT_ENCRYPTED_PRIVATE_KEY_INFO.xml' path='doc/member[@name="CRYPT_ENCRYPTED_PRIVATE_KEY_INFO.EncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER EncryptionAlgorithm;
    /// <include file='CRYPT_ENCRYPTED_PRIVATE_KEY_INFO.xml' path='doc/member[@name="CRYPT_ENCRYPTED_PRIVATE_KEY_INFO.EncryptedPrivateKey"]/*'/>
    public CRYPT_DATA_BLOB EncryptedPrivateKey;
}
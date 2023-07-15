// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMSG_CMS_SIGNER_INFO.xml' path='doc/member[@name="CMSG_CMS_SIGNER_INFO"]/*'/>
public partial struct CMSG_CMS_SIGNER_INFO
{
    /// <include file='CMSG_CMS_SIGNER_INFO.xml' path='doc/member[@name="CMSG_CMS_SIGNER_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CMSG_CMS_SIGNER_INFO.xml' path='doc/member[@name="CMSG_CMS_SIGNER_INFO.SignerId"]/*'/>
    public CERT_ID SignerId;
    /// <include file='CMSG_CMS_SIGNER_INFO.xml' path='doc/member[@name="CMSG_CMS_SIGNER_INFO.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='CMSG_CMS_SIGNER_INFO.xml' path='doc/member[@name="CMSG_CMS_SIGNER_INFO.HashEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;
    /// <include file='CMSG_CMS_SIGNER_INFO.xml' path='doc/member[@name="CMSG_CMS_SIGNER_INFO.EncryptedHash"]/*'/>
    public CRYPT_DATA_BLOB EncryptedHash;
    /// <include file='CMSG_CMS_SIGNER_INFO.xml' path='doc/member[@name="CMSG_CMS_SIGNER_INFO.AuthAttrs"]/*'/>
    public CRYPT_ATTRIBUTES AuthAttrs;
    /// <include file='CMSG_CMS_SIGNER_INFO.xml' path='doc/member[@name="CMSG_CMS_SIGNER_INFO.UnauthAttrs"]/*'/>
    public CRYPT_ATTRIBUTES UnauthAttrs;
}
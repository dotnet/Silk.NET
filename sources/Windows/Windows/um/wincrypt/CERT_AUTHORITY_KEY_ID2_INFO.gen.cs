// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_AUTHORITY_KEY_ID2_INFO.xml' path='doc/member[@name="CERT_AUTHORITY_KEY_ID2_INFO"]/*'/>
public partial struct CERT_AUTHORITY_KEY_ID2_INFO
{
    /// <include file='CERT_AUTHORITY_KEY_ID2_INFO.xml' path='doc/member[@name="CERT_AUTHORITY_KEY_ID2_INFO.KeyId"]/*'/>
    public CRYPT_DATA_BLOB KeyId;
    /// <include file='CERT_AUTHORITY_KEY_ID2_INFO.xml' path='doc/member[@name="CERT_AUTHORITY_KEY_ID2_INFO.AuthorityCertIssuer"]/*'/>
    public CERT_ALT_NAME_INFO AuthorityCertIssuer;
    /// <include file='CERT_AUTHORITY_KEY_ID2_INFO.xml' path='doc/member[@name="CERT_AUTHORITY_KEY_ID2_INFO.AuthorityCertSerialNumber"]/*'/>
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB AuthorityCertSerialNumber;
}
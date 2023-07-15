// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OCSP_CERT_ID.xml' path='doc/member[@name="OCSP_CERT_ID"]/*'/>
public partial struct OCSP_CERT_ID
{
    /// <include file='OCSP_CERT_ID.xml' path='doc/member[@name="OCSP_CERT_ID.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='OCSP_CERT_ID.xml' path='doc/member[@name="OCSP_CERT_ID.IssuerNameHash"]/*'/>
    [NativeTypeName("CRYPT_HASH_BLOB")]
    public CRYPT_DATA_BLOB IssuerNameHash;
    /// <include file='OCSP_CERT_ID.xml' path='doc/member[@name="OCSP_CERT_ID.IssuerKeyHash"]/*'/>
    [NativeTypeName("CRYPT_HASH_BLOB")]
    public CRYPT_DATA_BLOB IssuerKeyHash;
    /// <include file='OCSP_CERT_ID.xml' path='doc/member[@name="OCSP_CERT_ID.SerialNumber"]/*'/>
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB SerialNumber;
}
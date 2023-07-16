// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_ECC_SIGNATURE.xml' path='doc/member[@name="CERT_ECC_SIGNATURE"]/*'/>
public partial struct CERT_ECC_SIGNATURE
{
    /// <include file='CERT_ECC_SIGNATURE.xml' path='doc/member[@name="CERT_ECC_SIGNATURE.r"]/*'/>
    [NativeTypeName("CRYPT_UINT_BLOB")]
    public CRYPT_DATA_BLOB r;
    /// <include file='CERT_ECC_SIGNATURE.xml' path='doc/member[@name="CERT_ECC_SIGNATURE.s"]/*'/>
    [NativeTypeName("CRYPT_UINT_BLOB")]
    public CRYPT_DATA_BLOB s;
}
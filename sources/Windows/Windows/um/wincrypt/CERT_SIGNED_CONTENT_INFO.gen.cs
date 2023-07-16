// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_SIGNED_CONTENT_INFO.xml' path='doc/member[@name="CERT_SIGNED_CONTENT_INFO"]/*'/>
public partial struct CERT_SIGNED_CONTENT_INFO
{
    /// <include file='CERT_SIGNED_CONTENT_INFO.xml' path='doc/member[@name="CERT_SIGNED_CONTENT_INFO.ToBeSigned"]/*'/>
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB ToBeSigned;
    /// <include file='CERT_SIGNED_CONTENT_INFO.xml' path='doc/member[@name="CERT_SIGNED_CONTENT_INFO.SignatureAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;
    /// <include file='CERT_SIGNED_CONTENT_INFO.xml' path='doc/member[@name="CERT_SIGNED_CONTENT_INFO.Signature"]/*'/>
    public CRYPT_BIT_BLOB Signature;
}
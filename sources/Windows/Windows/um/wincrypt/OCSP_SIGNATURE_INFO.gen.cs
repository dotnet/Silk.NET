// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OCSP_SIGNATURE_INFO.xml' path='doc/member[@name="OCSP_SIGNATURE_INFO"]/*' />
public unsafe partial struct OCSP_SIGNATURE_INFO
{
    /// <include file='OCSP_SIGNATURE_INFO.xml' path='doc/member[@name="OCSP_SIGNATURE_INFO.SignatureAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

    /// <include file='OCSP_SIGNATURE_INFO.xml' path='doc/member[@name="OCSP_SIGNATURE_INFO.Signature"]/*' />
    public CRYPT_BIT_BLOB Signature;

    /// <include file='OCSP_SIGNATURE_INFO.xml' path='doc/member[@name="OCSP_SIGNATURE_INFO.cCertEncoded"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCertEncoded;

    /// <include file='OCSP_SIGNATURE_INFO.xml' path='doc/member[@name="OCSP_SIGNATURE_INFO.rgCertEncoded"]/*' />
    [NativeTypeName("PCERT_BLOB")]
    public CRYPT_DATA_BLOB* rgCertEncoded;
}

// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OCSP_SIGNED_REQUEST_INFO.xml' path='doc/member[@name="OCSP_SIGNED_REQUEST_INFO"]/*' />
public unsafe partial struct OCSP_SIGNED_REQUEST_INFO
{
    /// <include file='OCSP_SIGNED_REQUEST_INFO.xml' path='doc/member[@name="OCSP_SIGNED_REQUEST_INFO.ToBeSigned"]/*' />
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB ToBeSigned;

    /// <include file='OCSP_SIGNED_REQUEST_INFO.xml' path='doc/member[@name="OCSP_SIGNED_REQUEST_INFO.pOptionalSignatureInfo"]/*' />
    [NativeTypeName("POCSP_SIGNATURE_INFO")]
    public OCSP_SIGNATURE_INFO* pOptionalSignatureInfo;
}

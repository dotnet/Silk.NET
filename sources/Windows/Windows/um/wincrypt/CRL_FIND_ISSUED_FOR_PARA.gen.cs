// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRL_FIND_ISSUED_FOR_PARA.xml' path='doc/member[@name="CRL_FIND_ISSUED_FOR_PARA"]/*' />
public unsafe partial struct CRL_FIND_ISSUED_FOR_PARA
{
    /// <include file='CRL_FIND_ISSUED_FOR_PARA.xml' path='doc/member[@name="CRL_FIND_ISSUED_FOR_PARA.pSubjectCert"]/*' />
    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pSubjectCert;

    /// <include file='CRL_FIND_ISSUED_FOR_PARA.xml' path='doc/member[@name="CRL_FIND_ISSUED_FOR_PARA.pIssuerCert"]/*' />
    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pIssuerCert;
}
